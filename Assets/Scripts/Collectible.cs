using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Collectible : MonoBehaviour
{
    public AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(50*Time.deltaTime, 30 * Time.deltaTime, 30 * Time.deltaTime);
        

    }
    private void OnTriggerEnter(Collider trigger)
    {
        m_AudioSource.Play();
        Invoke(nameof(deActivateObject), 0.1f);
        trigger.gameObject.GetComponent<MovementController>().points();


      }
    private void deActivateObject()
    {
        gameObject.SetActive(false);
    }
}
    
