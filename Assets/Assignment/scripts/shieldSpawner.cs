using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldSpawner : MonoBehaviour
{
    //varibles
    public GameObject Shieldprefab;
    public Transform spawn;
    public float spawnOffsetX = 8f;
    public float spawnOffsetY = 4f;
    public float SpawnRate = 30f;
    private float timer = 0f;
    void Start()
    {
        spawnShield(); //gives a shield right away so the player doesn't have to wait
    }

    // Update is called once per frame
    void Update()
    {
        //spawn time in between 
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnShield();
            timer = 0f;
        }
    }

    void spawnShield()
    {
        //offsets for random spawn positions
        float leftSide = transform.position.x - spawnOffsetX;
        float rightSide = transform.position.x + spawnOffsetX;
        float northSide = transform.position.y - spawnOffsetY;
        float southSide = transform.position.y + spawnOffsetY;

        Instantiate(Shieldprefab, new Vector3(Random.Range(leftSide, rightSide), Random.Range(northSide, southSide), 0), spawn.rotation);
    }
}
