using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 10f;

    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 forwardInput = transform.forward * Input.GetAxis("Vertical");

        _playerRb.AddForce(forwardInput * speed, ForceMode.Acceleration);
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);

        //Movement();
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("End"))    
        {
            ManageLevel.Instance.Winner();
        }
    }
}
