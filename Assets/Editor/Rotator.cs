﻿using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour {


	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(eulerAngles: new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
