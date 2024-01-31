using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 10f;
    public float deadZoneX = 11f;
    public float deadZoneY = -7f;
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (transform.position.x > deadZoneX || transform.position.y < deadZoneY)
        {
            Destroy(gameObject);
        }
    }
}
