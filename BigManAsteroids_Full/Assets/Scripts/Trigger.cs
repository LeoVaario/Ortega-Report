﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    private Text Text1;
    private Text Text2;

    void Start()
    {
        Text1 = GameObject.Find("Text1").GetComponent<Text>(); //gets the text1 object
        
    }

    private void Update()
    {
        
        if (Input.GetKeyDown("c"))
        {
            Text1.color = new Color(255, 255, 255, 0); //hides text1
            //Text2.color = new Color(255, 255, 255, 0);
        }

    }


    void OnTriggerEnter2D (Collider2D Player) //triggers on enter
    {
        if (Player.gameObject.name == "PlayerShip" ) //if name is correct
        {
            //Debug.Log("Player entered trigger zone");
            Text1.color = new Color(255, 255, 255, 255); //shows text1
            GameObject.Find("Trigger1").GetComponent<BoxCollider2D>().enabled = false; //disables the collider
            StartCoroutine(Bye()); //starts the timer to hide text1

        }
    }
    IEnumerator Bye()
    {
        yield return new WaitForSeconds(10); //10s timer
        
        GameObject.Find("Text1").GetComponent<Text>().enabled = false; //disables text1

    }
}
