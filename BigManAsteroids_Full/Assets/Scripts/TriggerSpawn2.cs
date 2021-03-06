﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawn2 : MonoBehaviour
{

    public GameObject Spawned; 
    //public GameObject Spawned2; //swarms
    public GameObject TargetLocation;
    public GameObject TargetLocation2; //colonyship

    void OnTriggerEnter2D(Collider2D Ship) //triggers on enter
    {
        if (Ship.gameObject.name == "PlayerShip") //if the gameobject's name is correct
        {
            //Debug.Log("Object entered trigger zone");

            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 75, TargetLocation.transform.position.y + 25), TargetLocation.transform.rotation);// spawns indicated object at triggers center position +- values
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y + 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 90, TargetLocation.transform.position.y + 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 95, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 90, TargetLocation.transform.position.y + 50), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 80, TargetLocation.transform.position.y + 20), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 95, TargetLocation.transform.position.y + 10), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 85, TargetLocation.transform.position.y + 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 75, TargetLocation.transform.position.y - 25), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y - 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 90, TargetLocation.transform.position.y - 45), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 80, TargetLocation.transform.position.y - 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x + 95, TargetLocation.transform.position.y - 30), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 90, TargetLocation.transform.position.y - 50), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 80, TargetLocation.transform.position.y - 20), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 95, TargetLocation.transform.position.y - 10), TargetLocation.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation.transform.position.x - 85, TargetLocation.transform.position.y - 30), TargetLocation.transform.rotation);


            //enemies that attack colonyship
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 280, TargetLocation2.transform.position.y - 200), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 300, TargetLocation2.transform.position.y - 230), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 300, TargetLocation2.transform.position.y - 200), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 250, TargetLocation2.transform.position.y - 200), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 250, TargetLocation2.transform.position.y - 250), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 280, TargetLocation2.transform.position.y - 230), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 280, TargetLocation2.transform.position.y - 240), TargetLocation2.transform.rotation);
            Instantiate(Spawned, new Vector2(TargetLocation2.transform.position.x - 300, TargetLocation2.transform.position.y - 230), TargetLocation2.transform.rotation);

            GameObject.Find("Trigger1").GetComponent<BoxCollider2D>().enabled = false; //disables the trigger from use
            GameObject.Find("TriggerEnd").GetComponent<BoxCollider2D>().enabled = true;



        }
    }
}
