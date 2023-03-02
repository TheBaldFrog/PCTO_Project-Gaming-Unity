using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
       // Destroy();
    }*/

    private void OnCollisionEnter(Collision2D collision)
    {
        if (collision.gameObject.tag == "Somet$$anonymous$$ng")
        {
            Destroy(gameObject);
        }
    }
}
