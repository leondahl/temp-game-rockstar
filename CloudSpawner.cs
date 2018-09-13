using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject cloud;

	void Update ()
    {
        if (spawnTime >= 0)
        {
            spawnTime -= Time.deltaTime;
        }
        else if (spawnTime <= 0)
        {
            Instantiate(cloud);
            TimeReset();
        }
	}

    public void TimeReset()
    {
        spawnTime = Random.Range(1f, 5f);
    }
}
