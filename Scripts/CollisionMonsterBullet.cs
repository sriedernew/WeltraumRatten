using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBullet : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Monster" || c.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            if (c.gameObject.tag != "Wall")
            {
                GameController.energie = GameController.energie - GameController.eFaktor;
                if (GameController.energie % 100 == 0 && c.gameObject.tag == "Player")
                {
                    if (GameController.life < 1)
                    {
                        Destroy(c.gameObject);
                        Destroy(gameObject);
                    }
                }
                if (GameController.energie < 1)
                {
                    Destroy(c.gameObject);
                    Destroy(gameObject);
                }
            }
        }
	}

}
