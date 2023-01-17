using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSound : MonoBehaviour
{
    public AudioClip wallEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(wallEffect,transform.position);
    }
}
