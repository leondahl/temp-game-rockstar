using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{
    public float speed;

	void Start ()
    {
        speed = Random.Range(0.005f, 0.05f);
        transform.position = new Vector3(transform.position.x, transform.position.y - (speed*40));
	}

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed,transform.position.y);
    }
}
