using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perder : MonoBehaviour {

    public GameObject nave;
	private Vector2 PosicioInicialNave;
	public ColicionNave vidasnave;
	private int vidasacomparar = 0;

	void Start ()
	{
		PosicioInicialNave = nave.transform.position;
		//vidasacomparar = vidasnave.siguevivo;

	}
	void Update ()
	{
		//vidasnave.siguevivo = vidasacomparar;
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
		nave.GetComponent<Rigidbody2D> ().position = PosicioInicialNave;
		nave.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		vidasnave.vidas = vidasnave.vidas - 1;
    }
}
