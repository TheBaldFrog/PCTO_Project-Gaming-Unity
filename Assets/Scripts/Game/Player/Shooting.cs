using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    private int cont = 0;

    [SerializeField] private AudioSource FireSound;
    [SerializeField] private AudioSource ReloadSound;


    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
 
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                cont++;
                FireSound.Play();
                if (cont >= 6)
                {
                    ReloadSound.Play();
                    cont = 0;
                }

                nextAttackTime = Time.time + 1f /attackRate;
            }
        }
    }
    void Shoot()
    {
        GameObject bullet =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }

}
