using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody m_Rigidbody;
	public float m_Speed = 100;
	private AudioSource m_AudioSource;

	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody>();
		m_AudioSource = GetComponent<AudioSource>();
		m_Rigidbody.velocity = new Vector3(0, 0, m_Speed);
		m_AudioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		var currentVelocity = m_Rigidbody.velocity;

		if (currentVelocity.y <= 0f)
			return;

		currentVelocity.y = 0f;

		m_Rigidbody.velocity = currentVelocity;
	}
}
