using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField] private float _moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement();
        if(LevelManager.Instance.StartGame())
        {
            Movement();
        }
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("End"))    
        {
            LevelManager.Instance.Winner();
        }
    }
}
