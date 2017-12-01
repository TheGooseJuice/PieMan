﻿using UnityEngine;

public class StateGameIntro : GameState {

	private float m_countDown = 4f;

	public StateGameIntro(GameManager gm):base(gm) { }

	public override void Enter() { }

	public override void Execute() {
		if(m_countDown <= 0 ){
			//TODO: Update HUD 
			m_gm.NewGameState(m_gm.m_stateGameMenu); 
			m_gm.UpdateFSM(GameStates.MENU);

		} else {
			m_countDown -= Time.deltaTime;
		}
	}

	public override void Exit() {}
}
