﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_p1_2 : MonoBehaviour
{
    bool snapped = false;

    public bool IsSnapped() { return snapped; }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P_2_Collision")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //SceneManager.LoadScene("Main");

            snapped = true;
        }
    }
}
