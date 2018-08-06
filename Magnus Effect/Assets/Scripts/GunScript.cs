using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private Transform bulletStartPos;

	[SerializeField]
	private float force;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			GameObject go = (GameObject)Instantiate(bullet, bulletStartPos.position, Quaternion.identity);
			go.GetComponent<Rigidbody>().AddForce(Vector3.right * force, ForceMode.Impulse);
		}
	}

}
