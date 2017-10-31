using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour 
{
	
	public int dañoMoscas;
	public int dañoBoss;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		
		//this.gameObject.GetComponent<Rigidbody>().AddForce(fuerza, ForceMode.Impulse);
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Enemy"))
		{
			print("interceptó a la mosca");
			other.gameObject.GetComponent<MoscaBehaviour>().recibeDaño(dañoMoscas);
			Destroy(this.gameObject);
		}

		if(other.gameObject.tag.Equals("BossEnemy"))
		{
			print("interceptó a la mosca Boss");
			other.gameObject.GetComponent<MoscaBossBehaviour>().recibeDañoBoss(dañoBoss);
			Destroy(this.gameObject);
		}
	}
}
