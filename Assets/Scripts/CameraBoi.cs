﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoi : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;


    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update() {

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    { 
            transform.position = player.transform.position + offset;
    }

}
