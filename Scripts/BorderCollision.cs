using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D c){
        if (c.gameObject.tag != "Player") {
			Destroy (c.gameObject);
            if (c.gameObject.tag == "Monster") {
                GameController.life = GameController.life - GameController.sFaktor;
            }
		}
	}
}
