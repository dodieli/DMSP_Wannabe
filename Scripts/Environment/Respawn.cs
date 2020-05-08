﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
    	if(other.tag == "Player")
    	{
	    	player.transform.Translate(respawnPoint.transform.position - player.transform.position);
	    	Debug.Log(respawnPoint.transform.position - player.transform.position);
    	}    
    }


}