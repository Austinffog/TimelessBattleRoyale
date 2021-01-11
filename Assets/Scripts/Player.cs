using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Movement
    private float moveSpeed = 4f;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    #endregion

    #region Weapon
    public Transform firePoint;
    public GameObject bulletPrefab;
    private GameObject bullet;
    private Rigidbody2D bulletRb;
    private float destroyTime = 0.5f;
    private float bulletForce = 20f;
    public AudioSource bulletSound;
    #endregion

    // Update is called once per frame
    void Update()
    {
        Inputs();

        if (Input.GetKeyDown("w"))
        {
            ShootingUp();
            Sound();
        }
        else if (Input.GetKeyDown("a"))
        {
            ShootingLeft();
            Sound();
        }
        else if (Input.GetKeyDown("s"))
        {
            ShootingDown();
            Sound();
        }
        else if (Input.GetKeyDown("d"))
        {
            ShootingRight();
            Sound();
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    #region Movement Input
    private void Inputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void Movement()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    #endregion

    #region Shooting
    private void ShootingUp()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet.gameObject, destroyTime);
    }

    private void ShootingDown()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(-firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet.gameObject, destroyTime);
    }

    private void ShootingLeft()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(-firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet.gameObject, destroyTime);
    }

    private void ShootingRight()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet.gameObject, destroyTime);
    }

    private void Sound()
    {
        bulletSound.Play();
    }
    #endregion

    #region Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster1"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time -= 1f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                 GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
        }
        if (collision.gameObject.CompareTag("Monster2"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time -= 2.5f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
        }
        if (collision.gameObject.CompareTag("Monster3"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time -= 3.5f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
        }
        if (collision.gameObject.CompareTag("Monster4"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time -= 5f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
        }
        if (collision.gameObject.CompareTag("Monster5"))
        {
            GameObject.Find("TimeCount").GetComponent<GameTime>().time -= 15f;
            GameObject.Find("TimeCount").GetComponent<GameTime>().timeCount.text =
                GameObject.Find("TimeCount").GetComponent<GameTime>().time.ToString();
        }
    }
    #endregion
}

/*Sound
Freesound. 2021. Another magic wand by Timbre, 5 March 2014. [Online]. Available at: https://freesound.org/people/Timbre/sounds/221683/. [Accessed 10 January 2021]
Freesound. 2021. Orchestral Suspense loop 1 by Awrmacd, 6 April 2017. [Online]. Available at: https://freesound.org/people/awrmacd/sounds/387223/. [Accessed 10 January 2021]
 */
