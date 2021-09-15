using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDrop2: MonoBehaviour
{
    public GameObject objToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            SpawnIt();
        }
    }
    void SpawnIt()
    {
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
    }
}

