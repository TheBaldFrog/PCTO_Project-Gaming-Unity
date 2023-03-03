using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currenthealth { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = startingHealth;
    }

    

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - damage, 0, startingHealth);

        if (currenthealth <= 0) {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            TakeDamage(1);
        }
    }
}
