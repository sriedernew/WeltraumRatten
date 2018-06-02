using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovController : MonoBehaviour {

	public float speed = 10;

	void FixedUpdate(){
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Vector2 dir = new Vector2 (h,v);
		GetComponent<Rigidbody2D> ().velocity = dir.normalized * speed;

		GetComponent<Animator> ().SetBool ("fliegtNachOben",(v>0));
		GetComponent<Animator> ().SetBool ("fliegtNachLinks",(h<0));
		GetComponent<Animator> ().SetBool ("fliegtNachRechts",(h>0));
	}

}
