using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public bool isTargetPractice;
    public float health = 10f;
    public float defaulthealth;

    private void Start()
    {
        defaulthealth = health;
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        health = defaulthealth;
        Debug.Log("Target Broken");
    }
}
