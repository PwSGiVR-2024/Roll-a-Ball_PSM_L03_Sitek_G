using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float Thrust = 1;
    public TMP_Text scoreText;
    public TMP_Text LVL_Pass;
    bool Jump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump = true;
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
        if (Jump && Input.GetKeyDown("space") && score>=9)
        {
            rb.AddForce(Vector3.up * 10,ForceMode.Impulse);
            Jump = false;
        }
        
    }
    public void points()
    {
        score += 1;
        Debug.Log("Zdobyles punkt! Liczba zdobytych punktow: " + score);
        scoreText.text = "Score: " + score;
        if (score == 9)
        {
            print("Przeszedles pierwszy poziom!");
            Invoke(nameof(NextLvl), 4.0f);
        }
        if (score == 18)
        {
            print("Zdobyles wszystkie punkty! Gratuluje!");
            Credits();
        }
    }
    public void NextLvl()
    {
        SceneManager.LoadSceneAsync("LVL2", LoadSceneMode.Single);
    }
    public void Credits()
    {
        SceneManager.LoadSceneAsync("Credits", LoadSceneMode.Single);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = true;
        }
    }
}
