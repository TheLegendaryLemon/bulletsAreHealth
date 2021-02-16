using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //initializing variables
    public Transform firePoint;
    public GameObject bulletPrefab;
    public ammo getHealthUI;
    int ammo = 0;
    public float bulletForce = 20f;

    // Start is called before the first frame update
    private void Start()
    {
        //calls updateHealthCounter from the ammo class
        ammo = getHealthUI.updateHealthCounter();
    }

    // Update is called once per frame
    void Update()
    {
        //if left mouse clicked and ammo is greater then 0
        if (Input.GetMouseButtonDown(0) && (ammo > 0))
        {
            Shoot();
        }
    }

    //every time the player shoots
    public void Shoot()
    {       
        //creates a clone of the bullet prefab and sets its position, rotation, physics(rigid body) and force
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        //removes 1 from ammo and updates the counter
        ammo -= 1;
        getHealthUI.setHealthCounter(ammo);
    }
}
