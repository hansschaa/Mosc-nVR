using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoscaBehaviour : MonoBehaviour 
{
	[SerializeField]
	private Vector3 posicionJugador;

	[SerializeField]
	private int vida = 100;


	[SerializeField]
	private RectTransform barraVida;

	private GameObject gameController;

	public float speed;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		this.posicionJugador = GameObject.Find("CardboardMain").gameObject.transform.position;
		this.gameController = GameObject.Find("GameController").gameObject;
		this.transform.LookAt(posicionJugador);
	}
	// Update is called once per frame
	void Update () 
	{
		 float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, posicionJugador, step);
		
	}

	public void SetGazedAt(bool gazedAt) 
	{
		print("entro el punto  " + gazedAt);
  	}

	public void recibeDaño(int daño)
	{
		this.vida -= daño;
		barraVida.sizeDelta = new Vector2(vida, barraVida.sizeDelta.y);
		if(vida == 0)
		{
			gameController.GetComponent<UiController>().setMoscasMuertas();
			Destroy(this.gameObject);
			if(UiController.moscasMuertas%10==0)
			{
				print("que salga el jefazo");
				//gameController.GetComponent<GeneradorMoscas>().StopAllCoroutines();
				gameController.GetComponent<GeneradorMoscas>().generarJefazo();
			}
		}
		
	}
}
