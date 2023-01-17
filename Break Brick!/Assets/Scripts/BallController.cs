using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private GameObject _pedal;
    private bool isRunning;
    void Start()
    {
        _pedal = GameObject.FindObjectOfType<PedalController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning)
        {
            transform.position = new Vector3(_pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && !isRunning)
        {
            isRunning = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
}
