using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionPlayerWithEnimy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c){
        if (c.gameObject.tag == "Monster" ){
            Destroy(c.gameObject);
            GameController.life = GameController.life - GameController.sFaktor;
            if (GameController.life < 1)
            {
                Destroy(gameObject);
                Destroy(c.gameObject);
            }
		}
        if (c.gameObject.tag == "Bullet")
        {
            Destroy(c.gameObject);
        }
    }
}
