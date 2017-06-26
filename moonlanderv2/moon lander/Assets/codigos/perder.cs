using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perder : MonoBehaviour {

    public GameObject nave;

    private void OnCollisionEnter2D(Collision2D collision)
    {
		nave.SetActive (false);

    }
}
