using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float Thrust = 1;
    public TMP_Text scoreText;
    public TMP_Text LVL_Pass;
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
        if (Input.GetKey("space") && score>=10  )
        {
            rb.AddForce(Vector3.up * Thrust);
        }
    }
    public void points()
    {
        score += 1;
        Debug.Log("Zdobyles punkt! Liczba zdobytych punktow: " + score);
        scoreText.text = "Score: " + score;
        if (score == 9)
        {
            print("Przeszedles pierwszy poziom! Znajdz przycisk aby kontynuowac!");
        }
        if (score == 18)
        {
            print("Zdobyles wszystkie punkty! Gratuluje!");
        }
    }
}
