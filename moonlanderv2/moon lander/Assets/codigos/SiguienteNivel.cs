using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {

	public string NombreDeEscena;
	public GameObject nave;
	private float AvanzarNivel = 0f;
	public bool comprovarAcceso = false;

	void Start () 
	{
		// asegura que cadaves que se inicie el acceso sea negado
			comprovarAcceso = false;
		
	}
	

	void Update () 
	{

		AvanzarNivel = Input.GetAxisRaw ("siguentenivel");
		print (AvanzarNivel);

		if (comprovarAcceso) 
		{
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
