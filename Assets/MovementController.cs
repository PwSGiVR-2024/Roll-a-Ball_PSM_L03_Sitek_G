using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float Thrust = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
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
    }
    public void points()
    {
        score += 1;
        Debug.Log("Zdobyles punkt! Liczba zdobytych punktow: " + score);
        if (score == 9)
        {
            print("Zdobyles wszystkie punkty!");
        }
    }
}
