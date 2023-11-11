using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesseScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = Vector2.up * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; 
        }
       
        
    }
}
