using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScore : MonoBehaviour {

public RPGCharacterController m_cc;
public Text countScore;
public int m_holdScore;
	// Use this for initialization
	void Start(){
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(m_holdScore < m_cc.m_score){
			m_holdScore = m_cc.m_score;
		}

		
		
		countScore.text = "Score: " + m_holdScore.ToString();
	
	}
}
