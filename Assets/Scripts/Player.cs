using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

[SerializeField] float speed = 10f;
[SerializeField] Camera camera;

 void Update() {

    float horizontal = Input.GetAxisRaw("Horizontal"); 
    float vertical = Input.GetAxisRaw("Vertical");


    transform.position  = transform.position + new Vector3(horizontal, vertical) * Time.deltaTime * speed;
    
    Vector2
    
}












}



    



    
    



    


