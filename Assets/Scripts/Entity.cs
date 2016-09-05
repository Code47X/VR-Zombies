using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour
{

    // Handling
    public float health;

    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log("Dead");
        Destroy(gameObject);
    }
}