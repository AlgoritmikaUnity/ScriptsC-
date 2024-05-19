using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireball;
    public Transform attackPoint;
    public int coins;
    public void collectCoin()
    {
        coins += 1;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье орка: " + health);

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireball, attackPoint.position, attackPoint.rotation);
        }
    }
}