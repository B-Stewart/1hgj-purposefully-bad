using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    public float SecondsUntilDestroy = 6.0f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(DestroyAfterSeconds());
	}

    IEnumerator DestroyAfterSeconds()
    {
        yield return new WaitForSeconds(SecondsUntilDestroy);
        Destroy(this.gameObject);
    }
}
