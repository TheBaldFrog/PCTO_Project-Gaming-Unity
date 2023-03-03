using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ZM = GameObject.Find("Zombie_M");

        if (ZM != null)
        {
            Rigidbody2D zm = ZM.gameObject.GetComponent<Rigidbody2D>();

            zm.velocity = Vector3.zero;

            zm.angularVelocity = 0;
        }

        if (collision.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth playerComponent))
        {
           playerComponent.TakeDamage(damage);
        }
    }
}
