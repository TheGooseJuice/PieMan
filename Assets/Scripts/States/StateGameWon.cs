using UnityEngine;

public class StateGameWon : GameState {
	public RPGCharacterController m_cc;
	private float m_countDown = 5f;

	public StateGameWon(GameManager gm):base(gm) { }

	public override void Enter() {
		
	}

	public override void Execute() {
	}

	public override void Exit() {}

		public void PlayGame() {
		m_gm.NewGameState(m_gm.m_stateGamePlay);
		m_cc.scoreReset = true;
	}
	void Update()
	{
		
	}
	public void QuitGame() {
		Application.Quit();
	}
}


