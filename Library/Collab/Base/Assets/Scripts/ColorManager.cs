using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{

    public Canvas canvas;
    public GameObject ImageColoPrefab;
    //public Texture[] tabTexture;
    //public GameObject[] tabGameObject;
    public GameObject[] tabImage;
    public Material[] tabMaterial;
    public Vector3 ImagePosition;
    Color[] tabColor = new Color[90];
    Color color89;

    //===================1====================
    public static Color Color1 = new Color(43, 0, 0, 255);
    public static Color Color2 = new Color(128, 0, 0, 255);
    public static Color Color3 = new Color(212, 0, 0, 255);
    public static Color Color4 = new Color(255, 0, 0, 255);
    public static Color Color5 = new Color(255, 128, 128, 255);
    public static Color Color6 = new Color(255, 213, 213, 255);

    //===================2====================
    public static Color Color7 = new Color(43, 17, 0, 255);
    public static Color Color8 = new Color(85, 34, 0, 255);
    public static Color Color9 = new Color(170, 68, 0, 255);
    public static Color Color10 = new Color(255, 102, 0, 255);
    public static Color Color11 = new Color(255, 153, 85, 255);
    public static Color Color12 = new Color(255, 204, 170, 255);
    //===================3====================
    public static Color Color13 = new Color(43, 34, 0, 255);
    public static Color Color14 = new Color(85, 68, 0, 255);
    public static Color Color15 = new Color(170, 136, 0, 255);
    public static Color Color16 = new Color(255, 204, 0, 255);
    public static Color Color17 = new Color(255, 221, 85, 255);
    public static Color Color18 = new Color(255, 238, 170, 255);
    //===================4====================
    public static Color Color19 = new Color(43, 43, 0, 255);
    public static Color Color20 = new Color(68, 85, 0, 255);
    public static Color Color21 = new Color(136, 170, 0, 255);
    public static Color Color22 = new Color(204, 255, 0, 255);
    public static Color Color23 = new Color(221, 255, 85, 255);
    public static Color Color24 = new Color(238, 255, 170, 255);
    //===================5====================
    public static Color Color25 = new Color(17, 43, 0, 255);
    public static Color Color26 = new Color(34, 85, 0, 255);
    public static Color Color27 = new Color(68, 170, 0, 255);
    public static Color Color28 = new Color(102, 255, 0, 255);
    public static Color Color29 = new Color(153, 255, 85, 255);
    public static Color Color30 = new Color(204, 255, 170, 255);
    //===================6====================
    public static Color Color31 = new Color(0, 43, 0, 255);
    public static Color Color32 = new Color(0, 128, 0, 255);
    public static Color Color33 = new Color(0, 212, 0, 255);
    public static Color Color34 = new Color(85, 255, 85, 255);
    public static Color Color35 = new Color(128, 255, 128, 255);
    public static Color Color36 = new Color(213, 255, 213, 255);
    //===================7====================
    public static Color Color37 = new Color(0, 43, 34, 255);
    public static Color Color38 = new Color(0, 128, 102, 255);
    public static Color Color39 = new Color(0, 212, 170, 255);
    public static Color Color40 = new Color(0, 255, 204, 255);
    public static Color Color41 = new Color(85, 255, 221, 255);
    public static Color Color42 = new Color(170, 255, 238, 255);
    //===================8====================
    public static Color Color43 = new Color(0, 34, 43, 255);
    public static Color Color44 = new Color(0, 102, 128, 255);
    public static Color Color45 = new Color(0, 170, 212, 255);
    public static Color Color46 = new Color(0, 204, 255, 255);
    public static Color Color47 = new Color(85, 221, 255, 255);
    public static Color Color48 = new Color(170, 238, 255, 255);
    //==================9=====================
    public static Color Color49 = new Color(0, 17, 43, 255);
    public static Color Color50 = new Color(0, 51, 128, 255);
    public static Color Color51 = new Color(0, 68, 170, 255);
    public static Color Color52 = new Color(0, 102, 255, 255);
    public static Color Color53 = new Color(85, 153, 255, 255);
    public static Color Color54 = new Color(170, 204, 255, 255);
    //==================10====================
    public static Color Color55 = new Color(0, 0, 85, 255);
    public static Color Color56 = new Color(0, 0, 170, 255);
    public static Color Color57 = new Color(0, 0, 255, 255);
    public static Color Color58 = new Color(85, 85, 255, 255);
    public static Color Color59 = new Color(128, 128, 255, 255);
    public static Color Color60 = new Color(213, 213, 255, 255);
    //=================11=====================
    public static Color Color61 = new Color(17, 0, 43, 255);
    public static Color Color62 = new Color(34, 0, 85, 255);
    public static Color Color63 = new Color(85, 0, 212, 255);
    public static Color Color64 = new Color(153, 85, 255, 255);
    public static Color Color65 = new Color(204, 170, 255, 255);
    public static Color Color66 = new Color(229, 213, 255, 255);
    //=================12=====================
    public static Color Color67 = new Color(34, 0, 43, 255);
    public static Color Color68 = new Color(68, 0, 85, 255);
    public static Color Color69 = new Color(136, 0, 170, 255);
    public static Color Color70 = new Color(204, 0, 255, 255);
    public static Color Color71 = new Color(221, 85, 255, 255);
    public static Color Color72 = new Color(238, 170, 255, 255);
    //==================13====================
    public static Color Color73 = new Color(43, 0, 34, 255);
    public static Color Color74 = new Color(128, 0, 102, 255);
    public static Color Color75 = new Color(212, 0, 170, 255);
    public static Color Color76 = new Color(255, 0, 204, 255);
    public static Color Color77 = new Color(255, 85, 221, 255);
    public static Color Color78 = new Color(255, 213, 246, 255);
    //=================14=====================
    public static Color Color79 = new Color(40, 11, 34, 255);
    public static Color Color80 = new Color(128, 0, 51, 255);
    public static Color Color81 = new Color(170, 0, 68, 255);
    public static Color Color82 = new Color(255, 0, 102, 255);
    public static Color Color83 = new Color(255, 85, 153, 255);
    public static Color Color84 = new Color(255, 170, 204, 255);
    //=================15=====================
    public static Color Color85 = new Color(0, 0, 0, 255);
    public static Color Color86 = new Color(26, 26, 26, 255);
    public static Color Color87 = new Color(77, 77, 77, 255);
    public static Color Color88 = new Color(153, 153, 153, 255);
    public static Color Color89 = new Color(230, 230, 230, 255);
    public static Color Color90 = new Color(255, 255, 255, 255);

    private void Awake()
    {
        ////===================1====================
        //tabColor[0] = new Color(43, 0, 0,255);
        //tabColor[1] = new Color(128, 0, 0,255);//, 255);
        //tabColor[2] = new Color(212, 0, 0,255);//, 255);
        //tabColor[3] = new Color(255, 0, 0,255);//, 255);
        //tabColor[4] = new Color(255, 128, 128,255);//, 255);
        //tabColor[5] = new Color(255, 213, 213,255);//, 255);

        ////===================2====================
        //tabColor[6] = new Color(43, 17, 0, 255);
        //tabColor[7] = new Color(85, 34, 0, 255);
        //tabColor[8] = new Color(170, 68, 0, 255);
        //tabColor[9] = new Color(255, 102, 0, 255);
        //tabColor[10] = new Color(255, 153, 85, 255);
        //tabColor[11] = new Color(255, 204, 170, 255);
        ////===================3====================
        //tabColor[12] = new Color(43, 34, 0, 255);
        //tabColor[13] = new Color(85, 68, 0, 255);
        //tabColor[14] = new Color(170, 136, 0, 255);
        //tabColor[15] = new Color(255, 204, 0, 255);
        //tabColor[16] = new Color(255, 221, 85, 255);
        //tabColor[17] = new Color(255, 238, 170, 255);
        ////===================4====================
        //tabColor[18] = new Color(43, 43, 0, 255);
        //tabColor[19] = new Color(68, 85, 0, 255);
        //tabColor[20] = new Color(136, 170, 0, 255);
        //tabColor[21] = new Color(204, 255, 0, 255);
        //tabColor[22] = new Color(221, 255, 85, 255);
        //tabColor[23] = new Color(238, 255, 170, 255);
        ////===================5====================
        //tabColor[24] = new Color(17, 43, 0, 255);
        //tabColor[25] = new Color(34, 85, 0, 255);
        //tabColor[26] = new Color(68, 170, 0, 255);
        //tabColor[27] = new Color(102, 255, 0, 255);
        //tabColor[28] = new Color(153, 255, 85, 255);
        //tabColor[29] = new Color(204, 255, 170, 255);
        ////===================6====================
        //tabColor[30] = new Color(0, 43, 0, 255);
        //tabColor[31] = new Color(0, 128, 0, 255);
        //tabColor[32] = new Color(0, 212, 0, 255);
        //tabColor[33] = new Color(85, 255, 85, 255);
        //tabColor[34] = new Color(128, 255, 128, 255);
        //tabColor[35] = new Color(213, 255, 213, 255);
        ////===================7====================
        //tabColor[36] = new Color(0, 43, 34, 255);
        //tabColor[37] = new Color(0, 128, 102, 255);
        //tabColor[38] = new Color(0, 212, 170, 255);
        //tabColor[39] = new Color(0, 255, 204, 255);
        //tabColor[40] = new Color(85, 255, 221, 255);
        //tabColor[41] = new Color(170, 255, 238, 255);
        ////===================8====================
        //tabColor[42] = new Color(0, 34, 43, 255);
        //tabColor[43] = new Color(0, 102, 128, 255);
        //tabColor[44] = new Color(0, 170, 212, 255);
        //tabColor[45] = new Color(0, 204, 255, 255);
        //tabColor[46] = new Color(85, 221, 255, 255);
        //tabColor[47] = new Color(170, 238, 255, 255);
        ////==================9=====================
        //tabColor[48] = new Color(0, 17, 43, 255);
        //tabColor[50] = new Color(0, 51, 128, 255);
        //tabColor[51] = new Color(0, 68, 170, 255);
        //tabColor[52] = new Color(0, 102, 255, 255);
        //tabColor[53] = new Color(85, 153, 255, 255);
        //tabColor[54] = new Color(170, 204, 255, 255);
        ////==================10====================
        //tabColor[55] = new Color(0, 0, 85, 255);
        //tabColor[56] = new Color(0, 0, 170, 255);
        //tabColor[57] = new Color(0, 0, 255, 255);
        //tabColor[58] = new Color(85, 85, 255, 255);
        //tabColor[59] = new Color(128, 128, 255, 255);
        //tabColor[60] = new Color(213, 213, 255, 255);
        ////=================11=====================
        //tabColor[61] = new Color(17, 0, 43, 255);
        //tabColor[62] = new Color(34, 0, 85, 255);
        //tabColor[63] = new Color(85, 0, 212, 255);
        //tabColor[64] = new Color(153, 85, 255, 255);
        //tabColor[65] = new Color(204, 170, 255, 255);
        //tabColor[66] = new Color(229, 213, 255, 255);
        ////=================12=====================
        //tabColor[67] = new Color(34, 0, 43, 255);
        //tabColor[68] = new Color(68, 0, 85, 255);
        //tabColor[69] = new Color(136, 0, 170, 255);
        //tabColor[70] = new Color(204, 0, 255, 255);
        //tabColor[71] = new Color(221, 85, 255, 255);
        //tabColor[72] = new Color(238, 170, 255, 255);
        ////==================13====================
        //tabColor[73] = new Color(43, 0, 34, 255);
        //tabColor[74] = new Color(128, 0, 102, 255);
        //tabColor[75] = new Color(212, 0, 170, 255);
        //tabColor[76] = new Color(255, 0, 204, 255);
        //tabColor[77] = new Color(255, 85, 221, 255);
        //tabColor[78] = new Color(255, 213, 246, 255);
        ////=================14=====================
        //tabColor[79] = new Color(40, 11, 34, 255);
        //tabColor[80] = new Color(128, 0, 51, 255);
        //tabColor[81] = new Color(170, 0, 68, 255);
        //tabColor[82] = new Color(255, 0, 102, 255);
        //tabColor[83] = new Color(255, 85, 153, 255);
        //tabColor[83] = new Color(255, 170, 204, 255);
        ////=================15=====================
        //tabColor[84] = new Color(0, 0, 0, 255);
        //tabColor[85] = new Color(26, 26, 26, 255);
        //tabColor[86] = new Color(77, 77, 77, 255);
        //tabColor[87] = new Color(153, 153, 153, 255);
        //tabColor[88] = new Color(230, 230, 230, 255);
        //color89 = new Color(255, 255, 255, 255);

    }
    public Material[] tabMat = new Material[90];

    public static Color GetColor_(int i)
    {
        switch (i)
        {
            case 0:
                return Color1;
            case 1:
                return Color2;
            case 2:
                return Color3;
            case 3:
                return Color4;
            case 4:
                return Color5;
            case 5:
                return Color6;
            case 6:
                return Color7;
            case 7:
                return Color8;
            case 8:
                return Color9;
            case 9:
                return Color10;
            case 10:
                return Color11;
            case 11:
                return Color12;
            case 12:
                return Color13;
            case 13:
                return Color14;
            case 14:
                return Color15;
            case 15:
                return Color16;
            case 16:
                return Color17;
            case 17:
                return Color18;
            case 18:
                return Color19;
            case 19:
                return Color20;
            case 20:
                return Color21;
            case 21:
                return Color22;
            case 22:
                return Color23;
            case 23:
                return Color24;
            case 24:
                return Color25;
            case 25:
                return Color26;
            case 26:
                return Color27;
            case 27:
                return Color28;
            case 28:
                return Color29;
            case 29:
                return Color30;
            case 30:
                return Color31;
            case 31:
                return Color32;
            case 32:
                return Color33;
            case 33:
                return Color34;
            case 34:
                return Color35;
            case 35:
                return Color36;
            case 36:
                return Color37;
            case 37:
                return Color38;
            case 38:
                return Color39;
            case 39:
                return Color40;
            case 40:
                return Color41;
            case 41:
                return Color42;
            case 42:
                return Color43;
            case 43:
                return Color44;
            case 44:
                return Color45;
            case 45:
                return Color46;
            case 46:
                return Color47;
            case 47:
                return Color48;
            case 48:
                return Color49;
            case 49:
                return Color50;
            case 50:
                return Color51;
            case 51:
                return Color52;
            case 52:
                return Color53;
            case 53:
                return Color54;
            case 54:
                return Color55;
            case 55:
                return Color56;
            case 56:
                return Color57;
            case 57:
                return Color58;
            case 58:
                return Color59;
            case 59:
                return Color60;
            case 60:
                return Color61;
            case 61:
                return Color62;
            case 62:
                return Color63;
            case 63:
                return Color64;
            case 64:
                return Color65;
            case 65:
                return Color66;
            case 66:
                return Color67;
            case 67:
                return Color68;
            case 68:
                return Color69;
            case 69:
                return Color70;
            case 70:
                return Color71;
            case 71:
                return Color72;
            case 72:
                return Color73;
            case 73:
                return Color74;
            case 74:
                return Color75;
            case 75:
                return Color76;
            case 76:
                return Color77;
            case 77:
                return Color78;
            case 78:
                return Color79;
            case 79:
                return Color80;
            case 80:
                return Color81;
            case 81:
                return Color82;
            case 82:
                return Color83;
            case 83:
                return Color84;
            case 84:
                return Color85;
            case 85:
                return Color86;
            case 86:
                return Color87;
            case 87:
                return Color88;
            case 88:
                return Color89;
            case 89:
                return Color90;
            default: return Color90;

        }
    }

    void Start()
    {


        //tabTexture = new Texture[85];

        tabImage = new GameObject[10];


        for (int j = 0; j < tabImage.Length; j++)
        {
            GameObject currentImage = Instantiate(ImageColoPrefab, canvas.transform) as GameObject;
            //Material mat = tabMat[j];

            Image img = currentImage.GetComponent<Image>();
            img.name = "img-" + j;
            //img.color = tabMat[j].color;
            img.color = ColorTab.GetColor_(j);
            RectTransform rectTransform = currentImage.GetComponent<RectTransform>();
            rectTransform.transform.localPosition = new Vector3(ImagePosition.x + (j * 20), ImagePosition.y + ImagePosition.z);
        }

        /*for (int i = 0; i < tabImage.Length; i++)
        {
            tabImage[i].GetComponent<Image>().color = tabColor[i];
        }


        /*for (int i = 0; i < tabImage.Length; i++)
        {
            /*string path = "color" + (i+1);

            GameObject currentImage = Instantiate(ImageColoPrefab, canvas.transform) as GameObject;

            Image img = currentImage.GetComponent<Image>();
            Sprite sprite_ = Resources.Load(path) as Sprite;
            img.color = tabColor[i];
            RectTransform rectTransform = img.GetComponent<RectTransform>();
            rectTransform.transform.localPosition = new Vector3(ImagePosition.x+(i*20), ImagePosition.y, ImagePosition.z);

            //tabMaterial[i] =
            //tabTexture[i] = Resources.Load(path) as Texture;

            ////tabGameObject[i] = new GameObject();

            ////tabImage[i] = tabGameObject[i].AddComponent<Image>();

        }*/
    }
}
