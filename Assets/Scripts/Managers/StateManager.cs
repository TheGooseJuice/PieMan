﻿using UnityEngine;

public enum GameStates { INTRO, MENU, PLAY, WON, LOST }


public class StateManager : MonoBehaviour {

	public MusicStop m_stopAudio;
	public GameObject[] m_gameStates; 
	private GameStates m_activeState; 
	private int m_numStates;
	public RPGCharacterController m_cc;

	void Awake() {
		m_numStates = m_gameStates.Length;
		
		for(int i = 0; i < m_numStates; i++) {
			m_gameStates[i].SetActive(false);
		}

		m_activeState = GameStates.INTRO;
		m_gameStates[(int)m_activeState].SetActive(true); // 0 == menu	
		GameManager.Instance.StartGame();
	}

	public void ChangeState(GameStates newState){
		m_gameStates[(int)m_activeState].SetActive(false);
		m_activeState = newState;
		m_gameStates[(int)m_activeState].SetActive(true);
	}


	public void PlayGame() {
		GameManager.Instance.m_stateGameMenu.PlayGame();
		m_stopAudio.RemoveAudio();
		m_gameStates[(int)m_activeState].SetActive(false);
		m_activeState = GameStates.PLAY;
		m_gameStates[(int)m_activeState].SetActive(true);
		m_cc.scoreReset = true;
		
	}

	public void QuitGame() {
		GameManager.Instance.m_stateGameMenu.QuitGame();
	}


}

