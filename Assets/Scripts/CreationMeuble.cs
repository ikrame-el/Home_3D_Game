using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMeuble : MonoBehaviour
{
    //static float positionxMeuble;
     GameObject furniture;


    public void CreationMeubleChambreACoucher()
    {
        if (furniture == null)
        {
            createFurniture();
        }
    }

    void createFurniture()
    {
        string str = this.tag + "/" + this.name;
        Debug.Log("str = " + str);
        GameObject meuble = Resources.Load(str) as GameObject;
        meuble = Instantiate(meuble);
        furniture = meuble;

        furniture.AddComponent<ActionObject>();
        furniture.AddComponent<BoxCollider>();
    }
}
