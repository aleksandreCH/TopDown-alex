using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] float speed = 9.5f;
    [SerializeField] Camera camera;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject bulletapawnpoint;

    [SerializeField] GameObject secondbulletspownpoint;

    [SerializeField] GameObject killerbulletPrefab;

    float bulletFirerate;

    [SerializeField] float bulletFireratedefault;
    float killerbulletfirerate;

    [SerializeField] float killerbulletfireratedefault;


    void Update()
    {
        Move();
        Turn();

        bulletFirerate -= 1 * Time.deltaTime;
        if (bulletFirerate < 0 && Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, bulletapawnpoint.transform.position, transform.rotation);
            Instantiate(bulletPrefab, secondbulletspownpoint.transform.position, transform.rotation);
            bulletFirerate = bulletFireratedefault;
        }

        killerbulletfirerate -= 1 * Time.deltaTime;


        if (Input.GetMouseButtonDown(1) && killerbulletfirerate < 0)
        {
            Instantiate(killerbulletPrefab, secondbulletspownpoint.transform.position, transform.rotation);
            Instantiate(killerbulletPrefab, bulletapawnpoint.transform.position, transform.rotation);
            killerbulletfirerate = killerbulletfireratedefault;

        }









    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(horizontal, vertical) * Time.deltaTime * speed;
    }


    void Turn()
    {
        Vector2 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mouseWorldPosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}


