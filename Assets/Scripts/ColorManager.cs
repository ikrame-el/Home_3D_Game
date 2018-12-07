using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{

    //ATTENTION REGLER LE PROBLEME DU CLONE

    public Canvas canvas;

    public GameObject ImageColoPrefab;
    public Vector3 ImagePosition;
    public GameObject panelColorPalette;

    public Material[] tabMat = new Material[84];
    public GameObject[] tabImage;

    float posiXDefault = 98.4f;
    float posiYDefault = 67.3f;

    public Image[] tabStockageImage;

    static int cpt = 0;
    public void ColorManager_()
    {
        tabImage = new GameObject[84];
        tabStockageImage = new Image[tabImage.Length];
        int i = 0;
        int k = 0;
        int m = 0;
        if (cpt == 0)
        {
            while (k < 10)
            {
                m = 0;
                while (m < 9)
                {

                    GameObject currentImage = Instantiate(ImageColoPrefab, canvas.transform) as GameObject;
                    Image img = currentImage.GetComponent<Image>();
                    img.name = "img-" + i;
                    img.color = tabMat[i].color;
                    RectTransform rectTransform = currentImage.GetComponent<RectTransform>();
                    rectTransform.transform.localPosition = new Vector3(posiXDefault + (m * 18), posiYDefault - (k * 18), 0);

                    tabStockageImage[i] = img;
                    i++;
                    m++;
                }
                k++;
            }
            panelColorPalette.SetActive(true);
            cpt++;
        }
    }
}


