using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCreator : MonoBehaviour
{
//    public GameObject[] ships;
    //public List<GameObject> ships = new List<GameObject>();
GameObject[] ships;
    float shipPosX = 12;
    float shipPosY = 0;
    Transform ship;
    // Start is called before the first frame update

    Vector3 translationVector = new Vector3 (0,0,0);
    void Start()
    {
        
        ships = GameObject.FindGameObjectsWithTag("battleship");
            //ships = GameObject.FindGameObjectWithTag("battleship");
        for(int i = 1; i < ships.Length; i++)
        {
            ship = ships[i].GetComponent<Transform>();

            //shipPosX = 12;
            shipPosY = 4 * i;
            translationVector.x = shipPosX;
            translationVector.z = shipPosY;
            ship.Translate(translationVector);
            // shipPosX = ship.position.x;
            // shipPosY = ship.position.z;
            //ships.Add(ship);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
