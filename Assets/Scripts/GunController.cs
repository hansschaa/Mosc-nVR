using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	public GameObject currentBala;
	public float Bullet_Forward_Force;
	
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0) || CardboardSensor.CheckIfWasClicked())
		{
			GameObject bala = Instantiate(currentBala, transform.position, Quaternion.identity) as GameObject;
			bala.transform.Rotate(Vector3.left * 90);
			bala.GetComponent<Rigidbody>().AddForce(transform.forward * Bullet_Forward_Force);
			Destroy(bala,8f);
		
		}
		
	}
}
