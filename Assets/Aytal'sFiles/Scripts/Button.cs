﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(gameObject.name[0]);
	}

    void OnMouseUp()
    {
        //Debug.Log(12);
        SceneManager.LoadScene((Convert.ToInt32(gameObject.name[0]))-48);
    }
}
