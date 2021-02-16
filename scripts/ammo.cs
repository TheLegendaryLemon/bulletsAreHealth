using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo : MonoBehaviour
{
    //initilising variables
    public Sprite[] revolverSpriteArray;
    public SpriteRenderer revolverSpriteRenderer;
    public int healthUI;

    // Start is called before the first frame update
    void Start()
    {
        //allows the use of an image file
        revolverSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    //health counter
    public int updateHealthCounter()
    {
        healthUI = 8;
        return healthUI;
    }

    //set health for the shooting script while also updating with the shooting script
    public void setHealthCounter(int ammoShoot)
    {
        healthUI = ammoShoot;
        revolverSpriteRenderer.sprite = revolverSpriteArray[healthUI];
    }

   

//Update is called once per frame
void Update()
   {
        
   }
}
