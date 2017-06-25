using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Relative Rotation, works from 0 to rotation.

public class RotateBackAndForth2D : MonoBehaviour {

    public float rotation = 90;
    public float rotationTime = 1.0f;
    public bool randomOffset = false;

    private float offsetValue = 0.0f;


    // Use this for initialization
    void Start()
    {
        if (randomOffset)
            offsetValue = Random.value * 10 + 3;

        StartCoroutine(RotateForth());
    }

    IEnumerator RotateForth()
    {
        float t = 0.0f;

        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.forward, Time.deltaTime / (rotationTime * 0.5f) * (rotation + offsetValue));
            t += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(RotateBack());
    }

    IEnumerator RotateBack()
    {
        float t = 0.0f;

        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.forward, -Time.deltaTime / (rotationTime * 0.5f) * rotation);
            t += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(RotateForth());
    }
}
