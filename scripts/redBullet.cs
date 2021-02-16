using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBullet : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        
    }


    //destroys the bullet once it collides with an object
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}
