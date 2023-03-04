using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private AudioSource HitSound;
    [SerializeField] private float startingHealth;
    public float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = startingHealth;
    }

    

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        //HitSound.Play();

        if (currenthealth < 0) {
            
            Destroy(gameObject);
            //SceneManager.LoadScene("MainMenu");
            Debug.Log("Player Health");
        }
    }
}
