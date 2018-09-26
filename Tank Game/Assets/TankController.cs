using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {
    public float speed = 5;
    public float rotateSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W))
        { transform.Translate(0, 0, speed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.S))
        { transform.Translate(0, 0, -speed * Time.deltaTime); }

        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
        rotation *= Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(0, rotation, 0); }

        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(0, -rotation, 0); }
    }


    }

