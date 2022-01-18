using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 distance;
    public float smoothcamera;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("pass");
        distance = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }
    void follow()
    {
        Vector3 currentpos = transform.position;
        Vector3 targetpos = target.position - distance;
        transform.position = Vector3.Lerp(currentpos, targetpos, smoothcamera * Time.deltaTime);
    }
}

