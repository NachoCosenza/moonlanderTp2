using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionNave : MonoBehaviour {
	private float RangoParaAterrisaje = 0.75f;
	public bool AvtivadorDelObjeto = false;
	private Rigidbody2D rb;
	private MeshRenderer meshrender;
	private Vector2 PosicioInicialNave;
	public bool siguevivo = true; 

	public int vidas = 6;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		PosicioInicialNave = rb.transform.position;
	}



	private void OnCollisionEnter2D(Collision2D collision)
	{
		print (vidas);

		// calculo el rango de exito para aterrizar
		if ((rb.velocity.x > RangoParaAterrisaje) ||
		    (rb.velocity.x < -RangoParaAterrisaje) ||
		    (rb.velocity.y > RangoParaAterrisaje) ||
		    (rb.velocity.y < -RangoParaAterrisaje)) {
			// si no estra en el rango de exito se le resta una vida y resetea su posicion
			rb.position = PosicioInicialNave;
			rb.velocity = Vector2.zero;
			vidas = vidas - 1;
			siguevivo = false;
			print ("accedi");

		} else 
		{
			siguevivo = true;
			print ("accedi");
		}


	}
}
