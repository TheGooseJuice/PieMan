using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody piePrefab;
    public Transform barrelEnd;
    
	public float flightSpeed = 10.0f;
    private Animator m_animationController;
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        { 
			Rigidbody rocketInstance;
            rocketInstance = Instantiate(piePrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * flightSpeed);
			m_animationController.SetBool("isRangeAttacking", true);
			} else {
				m_animationController.SetBool("isRangeAttacking", false);
           
        }
	
    }
}