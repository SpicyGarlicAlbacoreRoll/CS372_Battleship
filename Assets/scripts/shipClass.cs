using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipClass : MonoBehaviour
{

    Vector3 shipPosition = new Vector3(0,0,0);
    Vector3 rotation = new Vector3(0, 0, 0);
    int shipHealth = 1;
     Mesh shipModel;
    bool shipAlive = true;
    bool placed = false;

    // Start is called before the first frame update
    void Start()
    {
        shipPosition = GetComponent<Transform>().position;
        this.transform.eulerAngles = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void takeDamage()
    {
        shipHealth--;
        if (shipHealth <= 0)
            shipAlive = false;
    }

}
