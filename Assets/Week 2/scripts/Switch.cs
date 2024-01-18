using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color myColor;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = myColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        spriteRenderer.color = Color.red;
        gameObject.SetActive(false);
        spriteRenderer.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = myColor;
    }
}
