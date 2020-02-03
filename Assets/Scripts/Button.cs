using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    
    Rigidbody2D rb2d;

    public float speed;

    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb2d.velocity = new Vector3(speed, -speed);
        Vector3 vel = rb2d.velocity;
        Debug.Log(rb2d.velocity);
        if (vel.magnitude != 0)
        {
            vel.Normalize();
            vel.x = vel.x * speed;
            vel.y = vel.y * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vel.y = jumpHeight;
        }
        rb2d.velocity = vel;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Needle")|| collision.gameObject.CompareTag("Pocket"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
