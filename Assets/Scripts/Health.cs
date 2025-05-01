using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    Score score;

    private void Start()
    {
        score = GameObject.FindWithTag("Scoreboard").GetComponent<Score>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet bullet = collision.GetComponent<bullet>();

        if (bullet)
        {
            health -= bullet.GetDamage();
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            score.IncreaseScore();
        }
    }
























}
