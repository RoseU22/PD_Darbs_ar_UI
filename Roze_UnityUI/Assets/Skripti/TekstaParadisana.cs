using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Mainīgais, kurā ieglabās tekstu no input field
	private string teksts;
	private int vecums;
	private string[] varianti = {"Impostor ", "ir ", " gadus vecs"};

	public GameObject ievadesLauks;
	public GameObject ievadesVecumaLauks;
	//Text, kurā attēlos tekstu
	public GameObject tekstaAttelosana;


	public void UzglabatTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		vecums = int.Parse (ievadesVecumaLauks.GetComponent<Text> ().text);

		tekstaAttelosana.GetComponent<Text>().text = varianti[0]+teksts+" "+varianti[1]+""+vecums+""+varianti[2];
	}
}
