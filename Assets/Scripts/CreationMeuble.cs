using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMeuble : MonoBehaviour
{
    GameObject furniture;
    string path;

    public void CreationMeuble_(string chemin)
    {
        path = chemin;
        createFurniture();
    }

    public void createFurniture()
    {

        GameObject meuble = Resources.Load(path) as GameObject;
        meuble = Instantiate(meuble);
        furniture = meuble;
        furniture.transform.position = new Vector3(0, 0, 0);
        furniture.AddComponent<ActionObject>();
        furniture.AddComponent<MouseDrag>();
        furniture.AddComponent<BoxCollider>();
    }

}
