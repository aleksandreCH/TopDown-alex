using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : MonoBehaviour

{
    [SerializeField] int hitCount = 3;



    void OnTriggerEnter2D(Collider2D col)
    {

        Destroy(gameObject);
        Destroy(col.gameObject);
    }




}


