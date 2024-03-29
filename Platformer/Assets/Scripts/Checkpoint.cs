﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
	private GameMaster gm;                          //reference to gamemaster

	void Start()
	{
		gm=GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))            //dali checkpointot collidnuva so player
		{
			gm.lastCheckPointPos=transform.position;
		}
	}
}
