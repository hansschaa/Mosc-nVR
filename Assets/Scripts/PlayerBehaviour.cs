using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour 
{
	[SerializeField]
	private float vidaTotal;
	public Text vidaCounText;

	// Use this for initialization
	void Start () 
	{
		this.vidaTotal = 100;
	}
	
	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("PoisonBullet"))
		{
			this.vidaTotal -= 5;
			vidaCounText.text = vidaTotal+"%";
			if(vidaTotal<=0)
			{
				SceneManager.LoadScene(0);	
			}
			
		}

		else if(other.gameObject.tag.Equals("Enemy"))
		{
			this.vidaTotal -= 3;
			vidaCounText.text = vidaTotal+"%";
			Destroy(other.gameObject);
			if(vidaTotal<=0)
			{
				SceneManager.LoadScene(0);	
			}
		}

		
	}


}
