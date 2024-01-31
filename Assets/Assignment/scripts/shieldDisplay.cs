using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldDisplay : MonoBehaviour
{
    //varibles
    SpriteRenderer spriteRenderer;
    Boolean shield = false;
    public float shieldTime = 10f;
    public float timer = 0f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //gets sprite render
    }

    // Update is called once per frame
    void Update()
    {
        if(shield == true) //displays shield sprite while shield is true
        {
            timer += Time.deltaTime;
            if (timer >= shieldTime)
            {
                shield = false;
                timer = 0f;
            }

            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shield = true; //makes shield true when hitting a shield object
    }
}
