using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {

	public string NombreDeEscena;
	public GameObject nave;
	private float AvanzarNivel = 0f;
	public bool comprovarAcceso = false;
	public ColicionNave comprobarVida;
	private bool comprovarAcceso2;

	void Start () 
	{
		// asegura que cadaves que se inicie el acceso sea negado
			comprovarAcceso = false;
			
		
	}
	

	void Update () 
	{
		comprovarAcceso2 = comprobarVida.siguevivo;
		print("acese1"+comprovarAcceso+"aceso2"+comprovarAcceso2);

		AvanzarNivel = Input.GetAxisRaw ("siguentenivel");



		if (comprovarAcceso && comprovarAcceso2)
		{print ("entre");
			if (AvanzarNivel == 1) 
			{			
				SceneManager.LoadScene (NombreDeEscena);
				print ("entre");
			}
		}
		
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
		print ("coliciona");
		comprovarAcceso = true;



	}


}
