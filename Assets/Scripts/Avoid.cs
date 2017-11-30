using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Avoid : MonoBehaviour {

public float speed = 3.0f;
public float speed2 = 0f;
public Transform target;

public Rigidbody m_rb;


public Collider m_hit;
bool InRange = false;


void Start()
{
    m_rb = GetComponent<Rigidbody>();
    
}


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
        Vector3 run = target.position - transform.position;
        run.y = 0;
        run.Normalize();
        m_rb.velocity =  run * speed;
           
        
   
        
    }


   
}
}
 
