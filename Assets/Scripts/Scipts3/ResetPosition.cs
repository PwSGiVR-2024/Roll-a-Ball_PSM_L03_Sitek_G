using UnityEngine;

public class ResetPositionOnCollision : MonoBehaviour
{
    private Vector3 startPosition;
    public string resetTriggerTag = "ResetPlane";

    void Start()
    {
        startPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(resetTriggerTag))
        {
            transform.position = startPosition;
        }
    }
}
