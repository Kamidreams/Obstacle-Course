using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 10f;
    public float _RotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
}
