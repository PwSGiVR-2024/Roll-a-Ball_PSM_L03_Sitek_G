using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class Collectible : MonoBehaviour
{
    public event Action pickUp;
    public AudioSource m_AudioSource;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(50*Time.deltaTime, 30 * Time.deltaTime, 30 * Time.deltaTime);
        

    }
    private void OnTriggerEnter(Collider trigger)
    {
        pickUp?.Invoke();
        m_AudioSource.Play();
        Invoke(nameof(deActivateObject), 0.1f);


      }
    private void deActivateObject()
    {
        gameObject.SetActive(false);
    }
}
    
