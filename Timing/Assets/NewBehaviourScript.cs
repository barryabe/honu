﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Texture2D arrow;
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector2 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}

