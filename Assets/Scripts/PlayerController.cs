using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float movementSpeed;
	public float rotateSpeed;

	private Rigidbody rbody;

	void Start () 
	{
		rbody = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		Vector3 moveVertical = new Vector3 (0, 0, Input.GetAxis ("Vertical")) * movementSpeed;
		Vector3 girar = new Vector3 (0, Input.GetAxis ("Horizontal"), 0) * rotateSpeed;
		transform.Translate (moveVertical);
		transform.Rotate (girar);
	}
	
	void FixedUpdate()
	{
		
	}
}
