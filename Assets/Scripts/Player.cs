using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] int health;
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] AudioSource audioSource;
    void Update()
    {
        Move();
        Turn();

        bulletFirerate -= 1 * Time.deltaTime;
        if (bulletFirerate < 0 && Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(audioSource.clip);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemi enemy = collision.GetComponent<Enemi>();

        if (enemy)
        {
            health -= enemy.GetDamge();
            healthText.text = "Health: " + health;

            if (health < 200)
            {
                healthText.color = Color.yellow;
            }

            if (health <= 100)
            {
                healthText.color = Color.red;
            }
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            sceneLoader.LoadGameOverUI();
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


