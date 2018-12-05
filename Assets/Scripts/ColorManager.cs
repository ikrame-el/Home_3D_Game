using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour {

    public Canvas canvas;
    public Texture[] tabTexture;
    public GameObject[] tabGameObject;
    public Image[] tabImage;

    void Start () {
        tabTexture = new Texture[85];

        for (int i = 0; i < tabTexture.Length; i++)
        {
            string path = "color" + (i+1);
            //tabTexture[i] = Resources.Load(path) as Texture;

            //tabGameObject[i] = new GameObject();

            //tabImage[i] = tabGameObject[i].AddComponent<Image>();

        }
    }
}
