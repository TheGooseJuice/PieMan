using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieHousePoints : MonoBehaviour {

	public int m_score;
	

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.tag == "Player"){
			m_score = m_score + 1;
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
