using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public int speedrt;

	void Start ()
    {

	}

	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1 * speedrt * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1 * speedrt * Time.deltaTime);
        }
    }
}