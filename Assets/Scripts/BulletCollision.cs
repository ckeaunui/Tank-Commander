using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public float damage;
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.hp = health.hp - damage;
        }

    }
}
