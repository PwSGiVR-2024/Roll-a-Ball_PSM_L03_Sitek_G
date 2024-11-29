using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    Rigidbody rb;
    public float Thrust = 1;
    bool Jump = true;
    bool canJump = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump = true;
        if(SceneManager.GetActiveScene().buildIndex == 1 )
        {
            canJump = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * Thrust);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * Thrust);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * Thrust);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * Thrust);
        }
        if (Jump && Input.GetKeyDown("space") && canJump)
        {
            rb.AddForce(Vector3.up * 10,ForceMode.Impulse);
            Jump = false;
        }
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = true;
        }
    }
}
