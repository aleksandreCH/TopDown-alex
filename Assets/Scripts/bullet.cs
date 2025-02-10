using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] float bulletspeed = 20f;

    void Start()
    {
        rb.AddForce(transform.up * bulletspeed, ForceMode2D.Impulse);
        Destroy(gameObject, 1f);
    }
}
