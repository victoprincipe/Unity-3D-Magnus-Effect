using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusPhysics : MonoBehaviour {

	[SerializeField]
	private float dragCoefficient;

	[SerializeField]
	private float crossSectionalArea;

	private Rigidbody rb;

	public float DragCoefficient {
		get {
			return dragCoefficient;
		}
	}

	public float CrossSectionalArea {
		get {
			return crossSectionalArea;
		}
	}

	public Rigidbody Rigidbody {
		get {
			return rb;
		}
	}

	private void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}
	
}
