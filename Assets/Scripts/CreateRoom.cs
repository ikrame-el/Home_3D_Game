using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviour
{
    public Button Button_create_room;
    //les mesure de la piece
    public Text inputWidth;
    public Text inputLength;

    float width;
    float length;

    GameObject mur1;
    GameObject mur2;
    GameObject mur3;
    GameObject mur4;
    GameObject mur5;
    GameObject mur6;
    GameObject mur7;
    GameObject mur8;
    GameObject sol;

    GameObject mur1_;
    GameObject mur2_;
    GameObject mur3_;
    GameObject mur4_;
    GameObject mur5_;
    GameObject mur6_;
    GameObject mur7_;
    GameObject mur8_;
    GameObject sol_;

    GameObject room;
    static int i = 1;

    bool isPressed = false;

    GameObject[] tabMur = new GameObject[8];


    void CreationMur(GameObject g1, out GameObject g2, string path, Vector3 position, Vector3 scale)
    {
        Debug.Log("creation");
        g2 = Instantiate(g1);
        g2.name = path;
        g2.transform.localPosition = position;
        g2.transform.localScale = scale;
    }

    public void Create_Room()
    {
        isPressed = !isPressed;
        room = new GameObject("room" + i);

        if (inputLength.text != "" && inputWidth.text != "")
        {
            width = float.Parse((inputWidth.text));
            length = float.Parse((inputLength.text));
        }

        //creation du sol de la piece
        sol = Resources.Load("Rooms/solPrefab") as GameObject;
        sol_ = Instantiate(sol, room.transform);
        sol_.transform.localScale = new Vector3(sol.transform.localScale.x / 10 * width, 1, sol.transform.localScale.z / 10 * length);

        for (int j = 0; j < tabMur.Length; j++)
        {
            tabMur[j] = Resources.Load("Rooms/mur" + (j + 1)) as GameObject;
        }

        //creation des mur interieur de la piece
        CreationMur(tabMur[0], out mur1_, "mur1", new Vector3(0, 3, length / 2 + .1f), new Vector3(tabMur[0].transform.localScale.x * width, 6, 0.2f));
        CreationMur(tabMur[1], out mur2_, "mur2", new Vector3(width / 2 + 0.1f, 3, 0), new Vector3(0.2f, 6, length + 0.8f));
        CreationMur(tabMur[2], out mur3_, "mur3", new Vector3(0, 3, -length / 2 - .1f), mur1_.transform.localScale);
        CreationMur(tabMur[3], out mur4_, "mur4", new Vector3(-width / 2 - .1f, 3, 0), mur2_.transform.localScale);
        CreationMur(tabMur[4], out mur5_, "mur5", new Vector3(0, 3, mur1_.transform.localPosition.z + 0.2f), mur1_.transform.localScale);
        CreationMur(tabMur[5], out mur6_, "mur6", new Vector3(width / 2 + 0.3f, 3, 0), mur2_.transform.localScale);
        CreationMur(tabMur[6], out mur7_, "mur7", new Vector3(0, 3, mur3_.transform.localPosition.z - 0.2f), mur1_.transform.localScale);
        CreationMur(tabMur[7], out mur8_, "mur8", new Vector3(mur4_.transform.localPosition.x + .2f, 3, 0), mur2_.transform.localScale);

        i++;
    }

    private void Update()
    {
        //Debug.Log("isPressed : " + isPressed);
        if (isPressed)
        {
            inputLength.text = "";
            inputWidth.text = "";
            Button_create_room.interactable = false;
        }
        else
        {
            Button_create_room.interactable = true;
        }

        /*if (inputLength.text != "" && inputWidth.text != "")
        {

        }*/
    }
}
