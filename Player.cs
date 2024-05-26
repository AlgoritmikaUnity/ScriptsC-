using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private int health = 10;
    public GameObject fireball;
    public Transform attackPoint;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health < 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;
        Instantiate(fireball, attackPoint.position, attackPoint.rotation);
    }
}

internal class damage
{
}