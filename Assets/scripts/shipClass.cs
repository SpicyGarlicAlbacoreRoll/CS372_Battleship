using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipClass : MonoBehaviour
{

    public Vector3 shipPosition = new Vector3(0,0,0);
    public Vector3 rotation = new Vector3(0, 0, 0);   

    public float onGrabElevation = 5.0f;
    int shipHealth = 1;
//  Mesh shipModel;
    bool shipAlive = true;
    bool placed = false;
    bool isGrabbed = false;
    Vector3 ninetyDegrees = new Vector3(0, 90, 0);


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
        if(Input.GetKeyDown(KeyCode.Q))
            rotateShip(ninetyDegrees);
        else if(Input.GetKeyDown(KeyCode.E))
            rotateShip(-ninetyDegrees);
    }

    

    void rotateShip(Vector3 rotateBy)
    {
        rotation.y += rotateBy.y;

        //Resets rotation value to 0 when reaching full circle
        if(rotation.y == 360 || rotation.y == -360)
            rotation.y = 0;
    }

    void OnMouseDown()
    {
    boatGrab();
    }

    void OnMouseUp() 
    {
        boatPlace();
    }

    public void takeDamage()
    {
        --shipHealth;
        if (shipHealth <= 0)
            shipAlive = false;
    }

    void boatGrab()
    {
        shipPosition.y += onGrabElevation;
    }

    void boatPlace()
    {
       shipPosition.y -= onGrabElevation; 
    }

}
