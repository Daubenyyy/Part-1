using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class launcher : MonoBehaviour
{
    //varibles
    public GameObject projectileprefab;
    public Transform spawner;
    public float SpawnRate = 2f;
    private float timer = 0f;
    public float spawnOffsetX = 9f;
    public float spawnOffsetY = 9f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)//adds time between projectile spawns
        {
            timer += Time.deltaTime;
        }
        else{
            spawnProjectile();
            timer = 0f;
        }
    }

    void spawnProjectile()
    {
        //offsets the projectiles to spawn in random places
        float leftSide = transform.position.x  - spawnOffsetX;
        float rightSide = transform.position.x + spawnOffsetX;
        float northSide = transform.position.y - spawnOffsetY;
        float southSide = transform.position.y + spawnOffsetY;

        Instantiate(projectileprefab, new Vector3(Random.Range(leftSide, rightSide), Random.Range(northSide, southSide), 0), spawner.rotation);
    }
}
