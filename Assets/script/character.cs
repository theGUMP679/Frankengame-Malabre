using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    //public Rigidbody2D Characterrb;
    public float characterspeed = 5.0f;
    public Rigidbody2D characterRBx;

    // Start is called before the first frame update
    void Start()
    {
        characterRBx = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 charactermove = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += charactermove * Time.deltaTime * characterspeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float JumpFoce = 5.0f;
            characterRBx.velocity = Vector2.up * JumpFoce;
        }

    }

    
}
