﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelected : MonoBehaviour
{
    static GameObject currentObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                /*if (hit.GetType() GameObject)
                {

                }*/
                Debug.Log("Type : " + hit.GetType());
                //currentObject = hit.collider.gameObject;
                //Debug.Log("objet selectionner : "+currentObject.name);
            }
        }
    }
}
