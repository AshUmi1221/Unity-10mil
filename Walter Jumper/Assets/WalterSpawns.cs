using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalterSpawns : MonoBehaviour
{
    public GameObject white;
    public float spawnRate = 2;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnwhite();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnwhite();
            timer = 0;
        }


    }

    void spawnwhite()
    {
        Instantiate(white, transform.position, transform.rotation);
    }
}
