﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Avoid : MonoBehaviour {

public float speed = 3.0f;
public float speed2 = 0f;
public Transform target;


public Collider m_hit;
bool InRange = false;


void OnTriggerEnter(Collider other)
{
    if(other.gameObject.tag == "Player" ){
    Debug.Log("hi");
    InRange = true;
    
}
}

void OnTriggerExit(Collider other)
{
    if(other.gameObject.tag == "Player" ){
    
    InRange = false;
    
}

   
    


}

void Update(){ 

    transform.Rotate(Vector3.right * Time.deltaTime * 100);
    if(InRange == true){
           float step = speed * Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    } else {
         float step = speed2 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }

   
}
}
 
