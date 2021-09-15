using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{

    public GameObject mainCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(mainCharacter.transform.position.x, mainCharacter.transform.position.y, mainCharacter.transform.position.z - 10);
    }
}
