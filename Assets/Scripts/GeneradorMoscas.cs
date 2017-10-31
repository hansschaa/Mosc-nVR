using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneradorMoscas : MonoBehaviour 
{
	public GameObject moscaPrefab;
	public GameObject[] listaDeGeneradores;

	public GameObject generadorJefazo;

	public GameObject jefazoMosca;
	public Vector3 posicionJugador;

	public float delayRespawn;



    // Use this for initialization
    void Start()
	{
		this.posicionJugador = GameObject.Find("CardboardMain").gameObject.transform.position;
		StartCoroutine(generadorMoscas());
	}

	IEnumerator generadorMoscas()
	{
		while(true)
		{
			GameObject generador = listaDeGeneradores[Random.Range(0,listaDeGeneradores.Length)];
			GameObject mosca = Instantiate(moscaPrefab, generador.transform.position,
			Quaternion.identity) as GameObject;

			mosca.transform.parent = generador.transform;
			yield return new WaitForSeconds(delayRespawn);
		}
	}


	public void generarJefazo()
	{
		GameObject jefazo = Instantiate(jefazoMosca, generadorJefazo.transform.position,Quaternion.identity) as GameObject;
		jefazo.transform.parent = generadorJefazo.transform;
	}
	
}
