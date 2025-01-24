using UnityEngine;

public class LeverMechanism : MonoBehaviour
{
    public Transform leverHandle;
    public Vector3 leverRightPosition;
    public GameObject wall;
    public float wallMoveDistance = 5f;
    public float wallMoveSpeed = 2f;
    private bool isNearLever = false;
    private bool leverActivated = false;
    private Vector3 wallStartPosition;
    private Vector3 wallTargetPosition;

    void Start()
    {
        wallStartPosition = wall.transform.position;
        wallTargetPosition = wallStartPosition + Vector3.up * wallMoveDistance;
    }

    void Update()
    {
        if (isNearLever && Input.GetKeyDown(KeyCode.E) && !leverActivated)
        {
            ActivateLever();
        }

        if (leverActivated)
        {
            wall.transform.position = Vector3.MoveTowards(wall.transform.position, wallTargetPosition, wallMoveSpeed * Time.deltaTime);
        }
    }

    void ActivateLever()
    {
        leverActivated = true;
        leverHandle.localPosition = leverRightPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearLever = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearLever = false;
        }
    }
}