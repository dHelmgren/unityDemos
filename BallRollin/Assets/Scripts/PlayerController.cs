using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	void Update(){

	}
	public float speed;//appears in the editor

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);//time.deltaTime

	}
}