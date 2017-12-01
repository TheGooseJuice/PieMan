using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {

	private Transform player;
	public float ViewDistance = 20f;
	private float distance;

	private Animator animate;

	private bool isMoving;
	private NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent<NavMeshAgent>();
		animate = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(player.position, transform.position);
		if(distance<=ViewDistance){
			nav.SetDestination(player.position);
			
		}
		if(distance<=3){
			animate.SetBool("IsAttacking", true);
		}
		else {
			animate.SetBool("IsAttacking", false);
		}
	Debug.Log(distance);
	}

}
