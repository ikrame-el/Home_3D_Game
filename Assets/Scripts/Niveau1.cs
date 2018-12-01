using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grille12x12 : MonoBehaviour
{
    public GameObject player;
    public Text messageDeFin;

    public GameObject[] tiles = new GameObject[12];
    GameObject case_;
    GameObject caseSprite;

    const int TAILLETAB = 12;
    int[,] plateauDeJeu = new int[TAILLETAB, TAILLETAB];
    int[] programme = new int[12];



    string[] jsonMap = new string[4];


    public GameObject[] instruction = new GameObject[12];
    Map map = new Map();
    Vector3 position_player;
    Vector3 arrive;

    void Start()
    {
        jsonMap[0] = @"{
  ""height"":12,
  ""width"":12,
  ""data"": 
  
    [0,10,0,0,0,0,0,0,0,0,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0,
     0,0,0,0,10,0,0,0,0,11,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0,
     0,0,11,0,0,0,0,0,0,0,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0,
     0,0,1,3,3,3,3,3,3,2,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0,
     0,0,0,0,0,0,0,0,10,0,0,0,
     0,0,0,0,10,0,0,0,0,0,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0,
     0,0,0,0,0,0,0,0,0,0,0,0],
""instructions"": [10,10,10,10,10,10,10,10,10,10,10,10]
}";
        JsonUtility.FromJsonOverwrite(jsonMap[0], map);
        Debug.Log("map : " + map.data[73]);

        for (int i = 0; i < TAILLETAB; i++)
        {
            for (int j = 0; j < TAILLETAB; j++)
            {
                //Resources.Load("Sprites/img") as GameObject;
                if (true)
                {
                    case_ = tiles[map.data[i + j * 12]];
                    //DETECTION DE LA POSITION DE DEPART DU PLAYER
                    if (map.data[i + j * 12] == 1)
                    {
                        position_player = new Vector2(i / 2f, j / 2f);
                    }
                    //DETECTION DE LA POSITION DE FIN DU PLAYER
                    if (map.data[i + j * 12] == 2)
                    {
                        arrive = new Vector2(i / 2f, j / 2f); ;
                    }
                }
                caseSprite = Instantiate(case_);
                caseSprite.transform.localPosition = new Vector2(i / 2f, j / 2f);
            }
        }

        player.transform.localPosition = position_player;

        for (int i = 0; i < map.instructions.Length; i++)
        {
            GameObject ins = Instantiate(instruction[0]);
            ins.name = "instruction" + i;
            ins.transform.localPosition = new Vector2(7, (i * 1.1f) / 2f);

        }




    }



    public void Clear()
    {
        for (int i = 0; i < map.instructions.Length; i++)
        {
            GameObject temp = GameObject.Find("instruction" + i); ;
            temp.transform.localPosition = new Vector2(7, (i * 1.1f) / 2f);

            stopRun = 0;
        }
    }


    void Avancer()
    {
        player.transform.localPosition += new Vector3(0.5f, 0, 0);
        //yield return new WaitForSeconds(5);
    }

    IEnumerator Run(int count)
    {
        for (int i = 0; i < count; i++)
        {
            
            yield return new WaitForSeconds(5);
            //Avancer();
            player.transform.localPosition += new Vector3(0.5f, 0, 0);
        }
        stopRun++;
    }

    /*IEnumerator MyCoroutine()
    {
        Debug.Log("Debut coroutine");
        
        Debug.Log("fin coroutine");
    }*/

    float cpt = 0f;
    float baseTab = 6.05f;

    int count = 0;

    int stopRun = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                //Debug.Log("hit.point : " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "button_clear")
                {
                    Clear();
                    player.transform.localPosition = position_player;
                    count = 0;
                    cpt = 0f;
                }
                else if (hit.collider.gameObject.name == "button_run")
                {
                    if (stopRun == 0)
                    {
                        Run(count);
                    }
                    cpt = 0f;
                }
                else
                {
                    hit.transform.localPosition = new Vector2(9, baseTab + cpt);
                    cpt -= 0.6f;
                    count++;
                }
            }
        }
       // StartCoroutine(Run(count));
        Debug.Log("player.transform.localPosition : " + player.transform.localPosition + " ; arrivee : " + arrive);

        Win();
    }





    void Win()
    {
        if (player.transform.localPosition == arrive)
        {
            Debug.Log("gagner");
            messageDeFin.gameObject.SetActive(true);
        }
    }

    /*if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                player.transform.localPosition += new Vector3(-0.5f, 0, 0);
                // player.transform.Translate(Vector3.right * -10 * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                player.transform.localPosition += new Vector3(0.5f, 0, 0);
                // player.transform.Translate(Vector3.right * 10 * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                player.transform.localPosition += new Vector3(0, 0.5f, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                player.transform.localPosition += new Vector3(0, -0.5f, 0);
            }*/
}
