using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //initializing variables
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public Animator animator;
    Vector2 movement;
    Vector2 mousePos;
    public Sprite[] playerSpriteArray;
    public SpriteRenderer playerSpriteRenderer;
    public ammo getHealthUI;
    int ammo = 0;

    // Update is called once per frame
    void Update()
    {
        //gets the x and y component for movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("speed", movement.sqrMagnitude);
        //gets the mouse position
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called at a stable rate
    private void FixedUpdate()
    {
        //makes the player move
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //gets the rotation for look direction
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "redBullets")
        {
            ammo -= 1;
            getHealthUI.setHealthCounter(ammo);
        }
    }
}
