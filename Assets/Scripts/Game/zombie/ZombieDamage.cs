using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    private PlayerHealth playerHealth;
    
    public int damage = 20;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            playerHealth = GameObject.FindWithTag("Player").gameObject.GetComponent<PlayerHealth>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);

            Debug.Log("AOOOOOOOOOOOO");
        }
    }
}
