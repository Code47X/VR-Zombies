using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    // Handling
    public float bulletDamage = 10f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Entity>()) {
            collision.collider.GetComponent<Entity>().TakeDamage(bulletDamage);
        }
    }
}