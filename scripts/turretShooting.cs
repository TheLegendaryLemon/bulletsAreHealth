using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShooting : MonoBehaviour
{
    //initializing variables
    public Transform turretFirePoint;
    public GameObject redBulletPrefab;
    public float bulletForce = 20f;
    public float waitTime = 1f;
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= waitTime)
        {
            time = time - waitTime;

            //creates a clone of the bullet prefab and sets its position, rotation, physics(rigid body) and force
            GameObject bullet = Instantiate(redBulletPrefab, turretFirePoint.position, turretFirePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(turretFirePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
