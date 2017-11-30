using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour {

	public Transform Explosion;
	public Transform PA_ArchLightRightBomb;
	public Transform PA_ArchLightLeftBomb;
	public float fpsTargetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float enemyMovementSpeed;
	public float damping;
	public Transform fpsTarget;
	Rigidbody theRigidbody;
	Renderer myRender;





	// Use this for initialization
	void Start () {
		myRender = GetComponent<Renderer>();
		theRigidbody = GetComponent<Rigidbody>();
		Explosion.GetComponent<ParticleSystem> () .enableEmission = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		fpsTargetDistance = Vector3.Distance(fpsTarget.position,transform.position);
		if(fpsTargetDistance<enemyLookDistance) {
			myRender.material.color=Color.yellow;
			lookAtPlayer();
			print ("look at playa please!");
		}
		if(fpsTargetDistance<attackDistance) {
			attackPlease();
			Debug.Log("ATTACK!");
		}
	}

	void lookAtPlayer() {
		Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*damping);
	}

	void attackPlease(){
		theRigidbody.AddForce(transform.forward*enemyMovementSpeed);
		PA_ArchLightLeftBomb.parent = null;
		PA_ArchLightRightBomb.parent = null;
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player"){
			Destroy(this.gameObject);
			transform.localRotation = Quaternion.Euler(100, 0, 0);
			
		}
	}

	//IEnumerator stopExplosion()

// 	{
// 		yield return new WaitForSeconds (.4f);

// 		Explosion.GetComponent<ParticleSystem> () .enableEmission = false;
// 	}

}
