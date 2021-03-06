﻿using UnityEngine;
using System.Collections;

public class ScreenClicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire2")) //right click
            Clicked();
	}

    private void Clicked()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        var hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit))
            Debug.Log(hit.collider.gameObject.name);

        var clickable = hit.collider.gameObject.GetComponent<IClickable>();
        clickable.OnClick(hit);
    }
}
