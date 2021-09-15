using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFall : MonoBehaviour
{

    //Ahn Falling Mechanic / Controls 2/2

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
        if (hitground.gameObject.CompareTag("Character1"))
        {
            StartCoroutine(hittingland());
        }

        else if (hitground.gameObject.CompareTag("Level"))
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