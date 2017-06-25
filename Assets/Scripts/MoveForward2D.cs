using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward2D : MonoBehaviour {

    public float Speed = 1.0f;

	// Update is called once per frame
	void Update ()
    {
        transform.position += Time.deltaTime * Speed * transform.up;
    }
}
