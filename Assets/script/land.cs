using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land : MonoBehaviour
{

    public Rigidbody2D rbx;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D hitground)
    {
        if (hitground.gameObject.CompareTag("Player"))
        {
            StartCoroutine(hittingland());
        }

        else if (hitground.gameObject.CompareTag("greenground"))
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator hittingland()
    {
        yield return new WaitForSeconds(0.1f);
        rbx.isKinematic = false;

    }
}
