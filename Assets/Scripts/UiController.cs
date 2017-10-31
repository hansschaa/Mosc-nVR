using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour 
{
	public static int moscasMuertas;

	public Text moscasMuertasCount;

	public GameObject panel;

	public string[] bibliotecaMensajes;

	public GameObject rank;
	public int rankNumber;

	// Use this for initialization
	void Start () 
	{		
		this.bibliotecaMensajes = new string[4];
		moscasMuertas = 0;
		rankNumber = Random.Range(5000,100000);
		rank.GetComponent<Text>().text = rankNumber+"";
		llenarArray();
	}
	
	public void setRank()
	{
		rankNumber = Random.Range(rankNumber-40,rankNumber);
		rank.GetComponent<Text>().text = rankNumber+"";
	}

	public void setMoscasMuertas()
	{
		moscasMuertas+=1;
		setRank();
		if(moscasMuertas%2==0)
		{
			StartCoroutine(aparecerMensaje());
		}

		moscasMuertasCount.text = ""+moscasMuertas;
	}

    IEnumerator aparecerMensaje()
    {
        panel.GetComponent<Animator>().SetBool("aparecer", true);
		GameObject texto = panel.transform.GetChild(0).gameObject;
		texto.GetComponent<Text>().text = bibliotecaMensajes[Random.Range(0, bibliotecaMensajes.Length)];

		yield return new WaitForSeconds(2.8f);
		panel.GetComponent<Animator>().SetBool("aparecer", false);
    }

	private void llenarArray()
    {
		bibliotecaMensajes[0]= "3D Waffle: No dejaré que me ganes!!";
		bibliotecaMensajes[1]= "Airport Hobo: Eres fabuloso";
		bibliotecaMensajes[2]= "K-9: Bien Hecho!";
		bibliotecaMensajes[3]= "Pusher: Has mejorado muchacho";     
		bibliotecaMensajes[4]= "Roadblock: No te rindas!!";  
		bibliotecaMensajes[5]= "Sandbox: Novato..77";  
		bibliotecaMensajes[6]= "Scrapper: Tarado..";  
		bibliotecaMensajes[7]= "Bugger: Has mejorado muchacho";  
		bibliotecaMensajes[8]= "Pogue: Tu puedes!!";  
    }
}
