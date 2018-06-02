using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(c.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            if (c.gameObject.tag != "Wall")
            {
                GameController.score = GameController.score + GameController.sFaktor;
                Destroy(c.gameObject);
            }
        }
    }

}
