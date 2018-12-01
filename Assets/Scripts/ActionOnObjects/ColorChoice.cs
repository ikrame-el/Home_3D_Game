using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChoice : MonoBehaviour {
    ActionObject currentObject;

    public void Color_White()
    {
        currentObject.GetComponent<Renderer>().material.color = Color.white;
    }

    public void Color_Red()
    {
        currentObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void Color_Black()
    {
        currentObject.GetComponent<Renderer>().material.color = Color.black;
    }
}
