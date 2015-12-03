using UnityEngine;
using System.Collections;

public class playerBehavior : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rb.velocity = new Vector3 (0, 0, .5f);
		//rb.AddRelativeForce(Vector3.forward*thrust);
	
	}
}
