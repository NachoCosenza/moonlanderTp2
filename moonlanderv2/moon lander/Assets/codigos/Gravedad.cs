using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour 
{
	public GameObject nave;
	private Transform gravedad;
	private float intecidadDeGravedad = 0.05f;

	void Awake()
	{
		gravedad = transform;
	}

	void Update () 
	{
		// genera la grabedad para el planeta;
		nave.GetComponent<Rigidbody2D> ().AddForce ((gravedad.position - nave.transform.position) * intecidadDeGravedad);
	}
}
