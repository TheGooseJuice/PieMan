using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {


public float m_timeLeft = 5;




	// Update is called once per frame
	void Update () {

			m_timeLeft -= Time.deltaTime;
			if ( m_timeLeft < 0 )
			{
				
				Destroy(gameObject);							
			}
	}
}
