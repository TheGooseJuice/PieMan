using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


	public int m_maxHP = 100;

	public float m_deathTime = 3f;

	public float m_hitReact = 0.1f;

	private int m_currentHealth;
	private Animator m_animController;

	private float m_hitDelay;

	private Transform m_agroTarget;

	void Start() {
		m_animController = GetComponent<Animator>();
		m_currentHealth = m_maxHP;
		
	}

	void Update() {
		if(m_hitDelay <= 0) {
			Die();
		}
	}

	public void ApplyDamage(int amount) {
		m_currentHealth -= amount;
		if(m_currentHealth <=0) {
			m_hitDelay = m_deathTime;
			m_animController.SetBool("died", true);
		}else{
			m_hitDelay = m_hitReact;
			m_animController.SetBool("tookDamage", true);
		}
	}

	private void Die() {
		if(m_hitDelay <= 0) {
			Destroy(gameObject);
		}
	}

	public Transform GetAgroTarget() {
		return m_agroTarget ? m_agroTarget : null;
	}

	public void SetAgroTarget(Transform target) {
		m_agroTarget = target;
}

}
