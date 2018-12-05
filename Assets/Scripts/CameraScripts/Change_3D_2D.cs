using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_3D_2D : MonoBehaviour
{

    public Camera cam;
    public GameObject camFPS;

    //les boutons de la direction de la main camera
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;

    static int nb = 1;
    bool isPressed = false;

    public void ChangeCamera()
    {
        isPressed = !isPressed;
        if (isPressed)
        {
            Utils_.Active_Desactive_5(b1, b2, b3, b4, cam.gameObject, false);
            camFPS.SetActive(true);
        }
        else
        {
            Utils_.Active_Desactive_5(b1, b2, b3, b4, cam.gameObject, true);
            camFPS.SetActive(false);
        }
    }
}
