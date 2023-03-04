using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private AudioSource HitSound;
    [SerializeField] float health, maxHealth = 3f;
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
        HitSound.Play();

        if (health <= 0) {
            SceneManager.LoadScene("MainMenu");
            Destroy(gameObject);
            
        }
    }
}
