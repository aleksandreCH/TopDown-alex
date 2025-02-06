using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        rb.AddForce(transform.up * 20f, ForceMode2D.Impulse);
        // Destroy(gameObject, 3f);
    }
}
