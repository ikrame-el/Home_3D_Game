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

    public InputField input1;
    public InputField input2;
    public Image menu;
    public Text text1;
    public Text text2;




    float width;
    float length;

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

    public static GameObject room;
    static int i = 1;

    bool isPressed = false;

    GameObject[] tabMur = new GameObject[8];


    void CreationMur(GameObject g1, out GameObject g2, string path, Vector3 position, Vector3 scale)
    {
        // Debug.Log("creation");
        g2 = Instantiate(g1, room.transform);
        g2.name = path;
        g2.transform.localPosition = position;
        g2.transform.localScale = scale;
    }

    public void TextFin()
    {
        inputLength.text = "";
        inputWidth.text = "";
    }

    public void Create_Room()
    {

        isPressed = !isPressed;
        room = new GameObject("room" + i);

        //verifier que c'est un float
        bool ok = float.TryParse(inputWidth.text, out width);

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
        CreationMur(tabMur[0], out mur1_, "mur1", new Vector3(0, 3, length / 2 + .1f), new Vector3(tabMur[0].transform.localScale.x * width, 10, 0.2f));
        CreationMur(tabMur[1], out mur2_, "mur2", new Vector3(width / 2 + 0.1f, 3, 0), new Vector3(0.2f, 10, length + 0.4f));
        CreationMur(tabMur[2], out mur3_, "mur3", new Vector3(0, 3, -length / 2 - .1f), mur1_.transform.localScale);
        CreationMur(tabMur[3], out mur4_, "mur4", new Vector3(-width / 2 - .1f, 3, 0), mur2_.transform.localScale);
        CreationMur(tabMur[4], out mur5_, "mur5", new Vector3(0, 3, mur1_.transform.localPosition.z + 0.2f), new Vector3(mur1_.transform.localScale.x + 0.4f, mur1_.transform.localScale.y, mur1_.transform.localScale.z));
        CreationMur(tabMur[5], out mur6_, "mur6", new Vector3(width / 2 + 0.3f, 3, 0), new Vector3(mur2_.transform.localScale.x, mur1_.transform.localScale.y, mur2_.transform.localScale.z + 0.4f));
        CreationMur(tabMur[6], out mur7_, "mur7", new Vector3(0, 3, mur3_.transform.localPosition.z - 0.2f), mur5_.transform.localScale);
        CreationMur(tabMur[7], out mur8_, "mur8", new Vector3(mur4_.transform.localPosition.x + .2f, 3, 0), mur2_.transform.localScale);

        room.tag = mur1_.tag;
        i++;
        TextFin();
    }

    public void OnClick_Create_Room()
    {
        isPressed = !isPressed;
        if (isPressed)
        {
            Utils_.Active_Desactive_5(input1.gameObject, input2.gameObject, menu.gameObject, text1.gameObject, text2.gameObject, true);
        }
        else
        {
            Utils_.Active_Desactive_5(input1.gameObject, input2.gameObject, menu.gameObject, text1.gameObject, text2.gameObject, false);
        }
    }

    private void Update()
    {
        if (inputLength.text != "" && inputWidth.text != "")
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Create_Room();
                Utils_.Active_Desactive_5(input1.gameObject, input2.gameObject, menu.gameObject, text1.gameObject, text2.gameObject, false);
            }

            //Deplacement d'une piece
            if (ObjectSelected.currentObject != null)
            {
                if (ObjectSelected.currentObject.tag == "room")
                {
                    if(Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        ObjectSelected.currentObject.transform.parent.position += new Vector3(-.5f, 0, 0);
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        ObjectSelected.currentObject.transform.parent.position += new Vector3(.5f, 0, 0);
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        ObjectSelected.currentObject.transform.parent.position += new Vector3(0, 0, .5f);
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        ObjectSelected.currentObject.transform.parent.position += new Vector3(0, 0, -.5f);
                    }
                }
            }
        }

    }
}
