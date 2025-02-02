﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LogicaSeguirJugador : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    public Animator animm;


    
    // Start is called before the first frame update
    void Start()
    {    
     
        player = GameObject.FindWithTag("Player");
        agent = this.GetComponent<NavMeshAgent>();
        animm = this.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);

        if (agent.remainingDistance <= 1)
            animm.SetBool("isMoving", false);
        else
            animm.SetBool("isMoving", true);
    }
}
