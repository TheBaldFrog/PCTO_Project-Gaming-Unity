using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;
    [SerializeField] HealthBar _healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;
        //_healthBar.TakeDamage(damage);


        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
