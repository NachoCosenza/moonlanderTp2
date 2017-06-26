using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPanel : MonoBehaviour {

	public GameObject panel;
	public GameObject PanelSecundario;


	public void OpenOrClose() 
	{
		if (panel.activeSelf) 
		{
			panel.SetActive (false);

			PanelSecundario.SetActive (true);
		}
		if (panel.activeSelf != true)
		{
			panel.SetActive (true);

			PanelSecundario.SetActive (false);
		}

	}
	

}
