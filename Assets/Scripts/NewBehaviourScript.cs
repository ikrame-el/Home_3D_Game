using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private void OnMouseDown()
    {
        /*pour changer de material de l'objet on est obliger de creer un new tableau et puis le 
         * remplir avec les diff material et faire ceciGetComponent<Renderer>().materials = mats;
        Material[] mats = new Material[3];
        ... ici on remplie le tableau mats avec les 3 materiaux 
        GetComponent<Renderer>().materials = mats;*/

        GetComponent<Renderer>().materials[1].color = Color.yellow;
    }
}
