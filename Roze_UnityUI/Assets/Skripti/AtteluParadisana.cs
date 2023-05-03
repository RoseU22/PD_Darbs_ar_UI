using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject mainigaisAttels;
    public GameObject CepuresmainigaisAttels;
    public GameObject KreklamainigaisAttels;
    public GameObject DzivniekamainigaisAttels;
    public GameObject KrekluAtteli;
    public GameObject CepuresAttels;
    public GameObject DzivniekaAttels;
    public Sprite[] atteluMasivs;
    public Sprite[] CepuresMasivs;
    public Sprite[] KreklaMasivs;
    public Sprite[] DzivniekaMasivs;
    public GameObject IzmeraSlaiderisY;
	public GameObject IzmeraSlaiderisX;

    public void KreklaAtteli(bool vertiba)
    {
        KrekluAtteli.SetActive(vertiba);
    }

    public void CepuresAtteli(bool vertiba)
    {
        CepuresAttels.SetActive(vertiba);
    }

    public void DzivniekaAtteli(bool vertiba)
    {
        DzivniekaAttels.SetActive(vertiba);
    }


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

    public void CepuresIzkritosais(int indekss)
    {
        if (indekss == 0)
            CepuresmainigaisAttels.GetComponent<Image>().sprite
            = CepuresMasivs[0];

        else if (indekss == 1)
            CepuresmainigaisAttels.GetComponent<Image>().sprite
            = CepuresMasivs[1];

        else if (indekss == 2)
            CepuresmainigaisAttels.GetComponent<Image>().sprite
            = CepuresMasivs[2];

        else if (indekss == 3)
            CepuresmainigaisAttels.GetComponent<Image>().sprite
            = CepuresMasivs[3];

        else if (indekss == 4)
            CepuresmainigaisAttels.GetComponent<Image>().sprite
            = CepuresMasivs[4];
    }

    public void KreklaIzkritosais(int indekss)
    {
        if (indekss == 0)
            KreklamainigaisAttels.GetComponent<Image>().sprite
            = KreklaMasivs[0];

        else if (indekss == 1)
            KreklamainigaisAttels.GetComponent<Image>().sprite
            = KreklaMasivs[1];

        else if (indekss == 2)
            KreklamainigaisAttels.GetComponent<Image>().sprite
            = KreklaMasivs[2];

        else if (indekss == 3)
            KreklamainigaisAttels.GetComponent<Image>().sprite
            = KreklaMasivs[3];
    }

    public void DzivniekaIzkritosais(int indekss)
    {
        if (indekss == 0)
            DzivniekamainigaisAttels.GetComponent<Image>().sprite
            = DzivniekaMasivs[0];

        else if (indekss == 1)
            DzivniekamainigaisAttels.GetComponent<Image>().sprite
            = DzivniekaMasivs[1];

        else if (indekss == 2)
            DzivniekamainigaisAttels.GetComponent<Image>().sprite
            = DzivniekaMasivs[2];

        else if (indekss == 3)
            DzivniekamainigaisAttels.GetComponent<Image>().sprite
            = DzivniekaMasivs[3];
    }

    public void mainitLielumu()
	{
		float pasreizejaisIzmersY = IzmeraSlaiderisY.GetComponent<Slider>().value;
		float pasreizejaisIzmersX = IzmeraSlaiderisX.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale = new Vector2(1f* pasreizejaisIzmersX, pasreizejaisIzmersY);
		mainigaisAttels.transform.localScale = new Vector2(pasreizejaisIzmersX, 1f*pasreizejaisIzmersY);
	}
		
}
