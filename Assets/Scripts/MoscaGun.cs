using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoscaGun : MonoBehaviour 
{

	public GameObject bulletPoison;
	public float Bullet_Forward_Force;

	public float delayDisparo;

	[SerializeField]
	private Vector3 posicionJugador;


	// Use this for initialization
	void Start () 
	{
		this.posicionJugador = GameObject.Find("Posicion").gameObject.transform.position;
		this.transform.LookAt(posicionJugador);
		StartCoroutine(respawnDisparos());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator respawnDisparos()
	{
		while(true)
		{
			yield return new WaitForSeconds(delayDisparo);
			GameObject bala = Instantiate(bulletPoison, transform.position, Quaternion.identity) as GameObject;
			 bala.GetComponent<Rigidbody>().velocity = (posicionJugador - bala.transform.position).normalized * Bullet_Forward_Force;
			//bala.transform.LookAt(posicionJugador);
			//bala.transform.Rotate(Vector3.left * 90);
			//bala.GetComponent<Rigidbody>().AddForce(transform.forward * Bullet_Forward_Force);
			
			Destroy(bala,8f);


		}
	
	}

}
