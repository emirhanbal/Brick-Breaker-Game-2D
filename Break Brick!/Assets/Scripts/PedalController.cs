using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalController : MonoBehaviour
{
    public AudioClip wallEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));
        transform.position = new Vector3(Mathf.Clamp(_mousePosition.x, -3f,3f), transform.position.y, transform.position.z); //mathf pedalı oyun ekranı içine sınırlandırdı//
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(wallEffect,transform.position);
    }
}
