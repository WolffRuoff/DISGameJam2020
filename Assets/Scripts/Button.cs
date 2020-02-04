using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public Sprite[] sprites;

    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    private bool onGround;
    private bool yarn;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        onGround = false;
        yarn = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb2d.velocity;
        Debug.Log(rb2d.velocity);
        if (yarn)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                speed = 7;
                sr.sprite = sprites[0];
                yarn = false;
            }
        } 

        if (vel.magnitude != 0)
        {
            vel.Normalize();
            vel.x = vel.x * speed;
            vel.y = vel.y * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            onGround = false;
            vel.y = jumpHeight;
        }
        rb2d.velocity = vel;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Needle")) 
        {
            SceneManager.LoadScene("Title Page");
        }

        

        if (collision.gameObject.CompareTag("Denim"))
        {
            onGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Yarn"))
        {
            yarn = true;
            sr.sprite = sprites[1];
            speed = 12;
            timer = 1.5f;
        }
    }
}
