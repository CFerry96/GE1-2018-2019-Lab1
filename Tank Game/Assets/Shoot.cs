using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject Bullet;
    public float bulletSpeed = 200;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject clone;
            clone = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        }
    }
}
