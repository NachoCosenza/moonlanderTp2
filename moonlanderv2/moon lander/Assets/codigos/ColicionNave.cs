using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionNave : MonoBehaviour {
	private float RangoParaAterrisaje = 0.75f;
	private bool AvtivadorDelObjeto = false;
	private Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
		if ((rb.velocity.x > RangoParaAterrisaje) || 
			(rb.velocity.x < -RangoParaAterrisaje)|| 
			(rb.velocity.y > RangoParaAterrisaje) || 
			(rb.velocity.y < -RangoParaAterrisaje)) 
		{
			gameObject.SetActive (AvtivadorDelObjeto);
		}

	}
}
