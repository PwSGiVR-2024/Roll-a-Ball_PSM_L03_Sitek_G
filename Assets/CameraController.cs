using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
    
{
    public GameObject Player;
    public MovementController playerController;
    Vector3 camera_position;
    // Start is called before the first frame update
    void Start()
    {
    
    camera_position= Player.transform.position-transform.position;

    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position - camera_position;
    }
}
    