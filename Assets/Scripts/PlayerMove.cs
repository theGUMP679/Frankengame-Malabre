using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //Ahn Falling Platform Mechanic/Controls Below 1/2
    //public Rigidbody2D Characterrb;
    public float speed = 5.0f;
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
        transform.position += charactermove * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float JumpForce = 7.5f;
            characterRBx.velocity = Vector2.up * JumpForce;
        }

    }
}
