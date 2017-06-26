using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour 
{

	private Rigidbody2D rb;
	public GameObject nave;
	private Transform gravedad;
	private float intecidadDeGravedad = 0.05f;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		gravedad = transform;
	}


	// Update is called once per frame
	void Update () 
	{
		// genera la grabedad para le planeta;
		nave.GetComponent<Rigidbody2D> ().AddForce ((gravedad.position - nave.transform.position) * intecidadDeGravedad);


	}
}
