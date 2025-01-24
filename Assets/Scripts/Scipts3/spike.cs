using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public float x = 10f;
    public float y = 0f;
    private float z;
    public bool rotatemax;
    private float rotationSpeed;
    public bool minus;
    void Start()
    {
        z = 0.0f;
        rotatemax = true;
        rotationSpeed = 16f;

    }

    void Update()
    {
        if (rotatemax)
        {
            z += Time.deltaTime * rotationSpeed;

            if (z > x)
            {
                rotatemax = false;
            }

        }
        else
        {
            z -= Time.deltaTime * rotationSpeed;

            if (z < y)
            {

                rotatemax = true;
            }
        }
        transform.rotation = Quaternion.Euler(0, z, 0);
    }
}