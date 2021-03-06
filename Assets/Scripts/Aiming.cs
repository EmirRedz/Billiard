﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {

    public LineRenderer laser;

	// Use this for initialization
	void Start ()
    {
        laser = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit))
        {
            if (hit.collider)
            {
                laser.SetPosition(1, new Vector3(0, 0, hit.distance));
            }
        }
        else
        {
            laser.SetPosition(1, new Vector3(0, 0, 5000));
        }
    }

}
