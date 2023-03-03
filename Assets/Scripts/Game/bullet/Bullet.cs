using JetBrains.Annotations;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //Destroy Bullets
        Destroy(this.gameObject);

        // Destroy Zombie
        if(collision.gameObject.TryGetComponent<ZombieHealth>(out ZombieHealth enemyComponent))
        {
            enemyComponent.TakeDamage(damage);
        }
    }
}
