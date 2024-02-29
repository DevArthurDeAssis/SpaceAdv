using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed = 10f;

    [Header("Shot Variables")]
    [SerializeField] private GameObject playerShot2;
    [SerializeField] private float shotCount;
    private float shotTimer = 0f;
    [SerializeField] private Transform firePointMiddle;
    [SerializeField] private Transform firePointLeft;
    [SerializeField] private Transform firePointRight;
    [SerializeField] private bool isPowerUp;
    [SerializeField] private float shotSpeed;

    [SerializeField] private int playerHealth2;

    [SerializeField] private GameObject destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isPowerUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        Movement2();
        ShotPlayer2();
    }

    private void ShotPlayer2()
    {
        shotTimer -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && shotTimer <= 0)
        {
            if (isPowerUp)
            {
                Instantiate(playerShot2, firePointLeft.position, firePointLeft.rotation);
                Instantiate(playerShot2, firePointMiddle.position, firePointMiddle.rotation);
                Instantiate(playerShot2, firePointRight.position, firePointRight.rotation);
            }
            else
            {
               var shot = Instantiate(playerShot2, firePointMiddle.position, firePointMiddle.rotation);
               shot.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, shotSpeed); 
            }

            shotTimer = shotCount;
        }
    }

    private void Movement2()
    {
        //Pegando os inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 shipVel = new Vector2(horizontal, vertical);

        shipVel.Normalize();

        rb2d.velocity = shipVel * speed;
    }

    public void PlayerDamage2(int damage)
    { 
        playerHealth2 -= damage;

        if (playerHealth2 <= 0)
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
