using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject IzmeraSlaideris;
	public GameObject RotacijasSlaideris;


	public void Izkritosais(int indekss)
	{
		if(indekss == 0)
			mainigaisAttels.GetComponent<Image>().sprite 
			= atteluMasivs[0];

		else if (indekss == 1)
			mainigaisAttels.GetComponent<Image>().sprite
			= atteluMasivs[1];

		else if (indekss == 2)
			mainigaisAttels.GetComponent<Image>().sprite
			= atteluMasivs[2];

		else if (indekss == 3)
			mainigaisAttels.GetComponent<Image>().sprite
			= atteluMasivs[3];
	}

	public void mainitLielumu()
	{
		float pasreizejaisIzmers =
			IzmeraSlaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale =
			new Vector2(1f* pasreizejaisIzmers,
				1f*pasreizejaisIzmers);
	}

	public void MainitRotaciju(){
		float pasreizejaVertiba = 
			RotacijasSlaideris.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localRotation =
			Quaternion.Euler (0, 0, pasreizejaVertiba * 360);
	}
}
