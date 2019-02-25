﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardInterface : MonoBehaviour
{

    public shipClass ship;
    //public playerClass player; maybe we need this?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            getMouseClick();
    }

    // getMouseClick
    // general mouse click handler function
    void getMouseClick()
    {
        RaycastHit clickInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out clickInfo);
        if (hit)
        {
            if (clickInfo.transform.gameObject.tag == "Ship") // && clickInfo.transform.gameObject.tag == player.tag (if we can differentiate between players in a class)
            {
                ship.takeDamage();
                markBoard();
            }
        }
    }

    // markBoard
    // after firing, marks the board as either a hit or miss
    void markBoard()
    {

    }


}
