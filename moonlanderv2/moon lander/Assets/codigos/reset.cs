using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reset : MonoBehaviour {

	public GameObject nave;
	//private Vector2 PosicioInicialNave;
	public ColicionNave vidasnave;

	private int vidasacomparar = 0;
	public string nombreDeEscena;

	void Update ()
	{
		vidasacomparar = vidasnave.vidas;
		if (vidasacomparar < 1) 
		{
			SceneManager.LoadScene (nombreDeEscena);
		}
	}



}
