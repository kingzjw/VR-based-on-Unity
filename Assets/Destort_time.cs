﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destort_time : MonoBehaviour {
    public float timer = 5.0f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
