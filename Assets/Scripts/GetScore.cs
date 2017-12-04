using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScore : MonoBehaviour {

public RPGCharacterController m_cc;
public Text countScore;
public Text currentScore;

	// Use this for initialization
	void Start(){
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
		currentScore.text = "your score: " + m_cc.m_yourScore.ToString();
		countScore.text = "Highscore: " + m_cc.m_highScore.ToString();
	
	}
}
