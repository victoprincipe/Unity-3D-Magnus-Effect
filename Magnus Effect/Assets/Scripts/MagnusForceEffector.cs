using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusForceEffector : MonoBehaviour {

	[SerializeField]
	private float areaDensity;
	
	private List<MagnusPhysics> mpList;

	void Start () 
	{
		mpList = new List<MagnusPhysics>();
	}
	
	void FixedUpdate () 
	{		
		foreach(MagnusPhysics mp in mpList)
		{
			float planeVel = new Vector3(mp.Rigidbody.velocity.x, 0, mp.Rigidbody.velocity.z).magnitude;
			float forceM = (mp.DragCoefficient * areaDensity * mp.CrossSectionalArea * Mathf.Pow(planeVel, 2f)) / 2;
			mp.Rigidbody.AddForce(Vector3.up * forceM);
		}		
	}

	private void OnTriggerEnter(Collider other) 
	{
		mpList.Add(other.GetComponent<MagnusPhysics>());	
	}

	private void OnTriggerExit(Collider other) 
	{
		mpList.Remove(other.GetComponent<MagnusPhysics>());	
	}

}
