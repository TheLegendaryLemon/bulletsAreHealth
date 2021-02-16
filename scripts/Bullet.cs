using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //destroys the bullet once it collides with an object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
