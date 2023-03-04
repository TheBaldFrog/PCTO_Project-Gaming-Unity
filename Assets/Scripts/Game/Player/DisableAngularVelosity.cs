using UnityEngine;

public class DisableAngularVelosity : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject go = GameObject.Find("Player");
        GameObject ZM = GameObject.Find("Player");

        if (go != null)
        {
            Rigidbody2D rbdy = go.gameObject.GetComponent<Rigidbody2D>();

            rbdy.velocity = Vector3.zero;

            rbdy.angularVelocity = 0;

            
        }

        /*if(ZM!= null)
        {
            Rigidbody2D zm = ZM.gameObject.GetComponent<Rigidbody2D>();

            zm.velocity = Vector3.zero;

            zm.angularVelocity = 0;

            
        }*/


    }
}
