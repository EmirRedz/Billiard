﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friction : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.angularDrag = 12F;
    }
}
