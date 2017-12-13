﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Ship) //triggers on enter
    {
        if (Ship.gameObject.name == "tanker(Clone)")
        {
            StartCoroutine(NextLevel());
        }
    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);

    }
}
