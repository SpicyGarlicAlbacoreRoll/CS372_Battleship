using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipClass : MonoBehaviour
{

    public Vector3 shipPosition;
    public Vector3 rotation = new Vector3(0, 0, 0);   

    public float onGrabElevation = 5.0f;
    int shipHealth = 1;
//  Mesh shipModel;
    bool shipAlive = true;
    bool placed = false;
    bool isGrabbed = false;
    Vector3 ninetyDegrees = new Vector3(0, 90, 0);
    public float gridUnits = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        shipPosition = GetComponent<Transform>().position;
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        controls();
        GetComponent<Transform>().position = shipPosition;
        this.transform.eulerAngles = rotation;
    }

    void controls()
    {
        if(isGrabbed == true)
        {
        shipControlRotate();
        shipControlMove();
        }
    }




    void OnMouseUp()
    {
        if (isGrabbed == false)
        {
            isGrabbed = true;
            boatGrab();
        } else if (isGrabbed == true)
        {
            isGrabbed = false;
            boatPlace();
        }
    }

/////////////// PUBLIC FUNCTIONS /////////////////////////
    public void takeDamage()
    {
        --shipHealth;
        if (shipHealth <= 0)
            shipAlive = false;
    }

/////////////// PRIVATE SHIP FUNCTIONS ////////////////////////
    private void boatGrab()
    {
        shipPosition.y += onGrabElevation;
    }

    private void boatPlace()
    {
       shipPosition.y -= onGrabElevation; 
    }

        private void rotateShip(Vector3 rotateBy)
    {
        rotation.y += rotateBy.y;

        //Resets rotation value to 0 when reaching full circle
        if(rotation.y == 360 || rotation.y == -360)
            rotation.y = 0;
    }

/////////////// SHIP CONTROLLER FUNCTIONS /////////////////

    void shipControlRotate()
        {
        if(Input.GetKeyDown(KeyCode.Q))
            rotateShip(ninetyDegrees);
        else if(Input.GetKeyDown(KeyCode.E))
            rotateShip(-ninetyDegrees);
        }

    void shipControlMove()
    {
        if(Input.GetButtonDown("Horizontal"))
            shipPosition.x += Input.GetAxisRaw("Horizontal") * gridUnits;        
        if(Input.GetButtonDown("Vertical"))
            shipPosition.z += Input.GetAxisRaw("Vertical") * gridUnits;   
    }

}
