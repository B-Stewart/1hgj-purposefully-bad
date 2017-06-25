using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootForward2D : MonoBehaviour {

    public GameObject PrefabToShoot;
    public float timeBetweenShots = 1.0f;
    public float delayBeforeShooting = 2.0f;
    public bool randomOffset = false;

    private float spawnDistance = 1.0f;
    private float randomValue = 0.0f;


	// Use this for initialization
	void Start ()
    {
        if (randomOffset)
            randomValue = (Random.value) * 0.5f;
        InvokeRepeating("ShootObject", delayBeforeShooting, timeBetweenShots + randomValue);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void ShootObject()
    {
        GameObject.Instantiate(PrefabToShoot, transform.position + spawnDistance * transform.up, transform.rotation);
    }
}
