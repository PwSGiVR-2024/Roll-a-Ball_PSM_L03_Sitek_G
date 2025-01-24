using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera sideViewCamera; 
    public Camera otherCamera; 

    void Start()
    {
        sideViewCamera.enabled = true;
        otherCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            sideViewCamera.enabled = !sideViewCamera.enabled;
            otherCamera.enabled = !otherCamera.enabled;
        }
    }
}
