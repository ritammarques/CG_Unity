﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount < 350)
        {
            transform.RotateAround(Vector3.zero, Vector3.right, 20f * Time.deltaTime);
        }
        transform.LookAt(Vector3.zero);
    }
}
