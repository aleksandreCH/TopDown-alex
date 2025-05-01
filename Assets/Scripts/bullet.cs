using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float bulletspeed = 20f;
    [SerializeField] int damage = 50;
    [SerializeField] bool DestoryOnContact;
    void Start()
    {
        rb.AddForce(transform.up * bulletspeed, ForceMode2D.Impulse);
        Destroy(gameObject, 1f);
    }
    public int GetDamage()
    {
        return damage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DestoryOnContact)
        {
            Destroy(gameObject);
        }
    }

}


