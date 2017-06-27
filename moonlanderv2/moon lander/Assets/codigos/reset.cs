using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reset : MonoBehaviour {

	private float retry = 0f;
	public GameObject nave;
	private Vector2 PosicioInicialNave;

	public ColicionNave vidasnave;

	private int vidasacomparar = 0;
	public string nombreDeEscena;

	//private Vector2 AnguloInicialNave;
	void Start () 
	{
		PosicioInicialNave = nave.transform.position;
	}
	

	void Update ()
	{
		vidasacomparar = vidasnave.vidas;
		
		retry = Input.GetAxisRaw ("retry");

		if (vidasacomparar < 1) 
		{
			SceneManager.LoadScene (nombreDeEscena);
		}
	}



}
