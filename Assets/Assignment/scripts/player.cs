using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    //varibles
    Vector2 acceleration;
    public float speed = 5f;
    Rigidbody2D rigidbody;
    public Boolean shielded = false;
    public float shieldTime = 10f;
    public float timer = 0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); //gets the rigid body
    }

    // Update is called once per frame
    void Update()
    {
        //player orientation
        acceleration.x = Input.GetAxis("Horizontal");
        acceleration.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //player moves when keys pressed
        rigidbody.AddForce(acceleration * speed * Time.deltaTime);

        if(shielded == true) //player is shielded for 10 seconds
        {
            timer += Time.deltaTime;
            if(timer >= shieldTime)
            {
                shielded = false;
                timer = 0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(shielded == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restarts the game if the player hits an object and isn't shielded
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shielded = true; //shields the player when grabbing shield item
    }
}
