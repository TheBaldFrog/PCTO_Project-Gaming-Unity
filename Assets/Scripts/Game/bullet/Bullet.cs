using JetBrains.Annotations;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 50;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);

        if(collision.gameObject.TryGetComponent<ZombieHealth>(out ZombieHealth enemyComponent))
        {
            enemyComponent.TakeDamage(damage);
        }
    }
}
