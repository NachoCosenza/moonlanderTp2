using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoParalax : MonoBehaviour {

	private Rigidbody2D rb;
	public float fuerza;
	private float vertical = 0f;
	private float horizontal = 0f;
	public GameObject nave;


	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Start () 
	{
		
	}

	void FixedUpdate()
	{
		if (nave.GetComponent<Rigidbody2D> ().velocity.x > 0)
		{
			transform.Translate (Vector2.left * fuerza * Time.deltaTime);			
		}

		if (nave.GetComponent<Rigidbody2D> ().velocity.x < 0)
		{
			transform.Translate (Vector2.right * fuerza * Time.deltaTime);			
		}

	}

}
