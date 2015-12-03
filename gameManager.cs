using UnityEngine;
using System.Collections;


public class gameManager : MonoBehaviour {
	public GameObject worldRotation;
	public float damp;
	public float distance;
	public Camera pCamera;
	public GameObject playerObject;
	public Transform target;
	public Vector3 diff;
	public float dist;

	// Use this for initialization
	void Start () {
		damp = 0.2f;
		distance = 50;
		dist = diff.magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		//pCamera = transform.position;
		//playerObject = target.position;
		//diff = playerObject - pCamera;
		//if (Mathf.Abs (diff.y) < 0.7f * distance) {
			//diff.y = 0;
		//}
		//if (dist > distance) {
			//diff *= 1-distance/dist;
			//transform.position = pCamera + diff * Time.deltaTime/damp;
		//}
		//transform.LookAt (playerObject);



		if (Input.GetKey (KeyCode.D)) {
			worldRotation.transform.Rotate(Vector3.back);
		}

		if (Input.GetKey (KeyCode.A)) {
			worldRotation.transform.Rotate(Vector3.forward);
		}

		if(Input.GetKey(KeyCode.W)) {
			worldRotation.transform.Rotate(Vector3.right);
		}

		if (Input.GetKey (KeyCode.S)) {
			worldRotation.transform.Rotate(Vector3.left);
		}

}
}