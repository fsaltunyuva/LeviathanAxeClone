using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandbox : MonoBehaviour
{
    public float interpolator = 0f;
    private Vector3 startPosition;
    public Transform targetPosition; 
    
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(startPosition, targetPosition.position, interpolator);
        interpolator += Time.deltaTime; 
        interpolator = Mathf.Clamp01(interpolator);

    }
}
