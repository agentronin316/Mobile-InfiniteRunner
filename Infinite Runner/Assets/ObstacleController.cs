﻿using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

    GameObject obstaclePrefab;
    float speed = -3.0f;
    GameObject playerObj;

	// Use this for initialization
	void Start ()
    {
        Invoke("SpawnObstacle", 3f);
	}
	
	// Update is called once per frame
	void SpawnObstacle ()
    {
        //spawn an obstacle at x 10, y -4 to 0
        Vector3 spawnPos = new Vector3(10, Random.Range(-4, 0), 0);
        GameObject tempObstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.Euler(Vector3.zero)) as GameObject;
        tempObstacle.name = "Obstacle";
        tempObstacle.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Ninja")
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
