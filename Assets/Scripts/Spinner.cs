using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    /*
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    */
    [SerializeField] float rotationSpeed = 50f;
    // Update is called once per frame
    void Update()
    {
        /*
        transform.Rotate(xAngle, yAngle, zAngle);
        */
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
