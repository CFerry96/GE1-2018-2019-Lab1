using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWall : MonoBehaviour {
    public GameObject Wall;

	// Use this for initialization
	void Start () {
        for (int c = 0; c < 10; c++)
        {
            for (int r = 0; r < 10; r++)
            {
                Instantiate(Wall, new Vector3(c * 1.1f, 0.5f + r * 1.1f, 0), transform.rotation);
            }
        }
	}
	//primitive, nested for loop
	// Update is called once per frame
	void Update () {
		
	}
}
