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
        //if (furniture == null)
        //{
            createFurniture();
        //}
    }
    public void createFurniture()
    {

        GameObject meuble = Resources.Load(path) as GameObject;
        meuble = Instantiate(meuble);
        furniture = meuble;
        furniture.transform.position = new Vector3(0,0,0);

        furniture.AddComponent<ActionObject>();
        furniture.AddComponent<BoxCollider>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            /*if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                GameObject current = hit.collider.gameObject;
                Debug.Log("current.name : " + current.name);
                Debug.Log("Rayyyyy1");

                if ( current.tag == "imgMeuble")
                {
                    Debug.Log("Rayyyyy2");
                    path = "FBX/" + current.name;
                }
            }*/
        }
    }
}
