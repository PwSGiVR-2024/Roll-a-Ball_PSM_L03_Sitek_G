using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(50*Time.deltaTime, 30 * Time.deltaTime, 30 * Time.deltaTime);
        

    }
    private void OnTriggerEnter(Collider trigger)
    {
        trigger.gameObject.GetComponent<MovementController>().points();
        gameObject.SetActive(false);
      

    }
}
    
