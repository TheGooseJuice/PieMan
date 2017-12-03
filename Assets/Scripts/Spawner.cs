using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
public float timeCounted = 0;
bool Spawn = false;
public Rigidbody berryPrefab;

public Transform barrelEnd;
public float flightSpeed;
public float timeLeft = 5;
public static DestroyAfterTime instance;


	public void Spawning(){

		Rigidbody berryInstance;
			berryInstance = Instantiate(berryPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			berryInstance.AddForce(barrelEnd.forward * flightSpeed);
		
	}



	private void timeCount(){
		timeLeft = 10;
		Spawn = true;
			

	}

	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime;
     	if ( timeLeft < 0 )
    	{
		
			timeCount();

			if(Spawn == true) {
				
				Spawning();
				Spawn = false;
				timeCounted = 1;
			}
			
		}
	}
}
