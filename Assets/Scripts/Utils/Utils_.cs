using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils_ : MonoBehaviour {

    public static void Active_Desactive_2(GameObject game1, GameObject game2, bool boool)
    {
        game1.SetActive(boool);
        game2.SetActive(boool);
    }

    public static void Active_Desactive_3(GameObject game1, GameObject game2, GameObject game3, bool boool)
    {
        Active_Desactive_2(game1, game2, boool);
        game3.SetActive(boool);
    }
    public static void Active_Desactive_4(GameObject game1, GameObject game2, GameObject game3, GameObject game4, bool boool)
    {
        Active_Desactive_2(game1, game2, boool);
        Active_Desactive_2(game3, game4, boool);
    }

    public static void Active_Desactive_5(GameObject game1, GameObject game2, GameObject game3, GameObject game4, GameObject game5, bool boool)
    {
        Active_Desactive_3(game1, game2, game3, boool);
        Active_Desactive_2(game5, game4, boool);
    }

    public static void Active_Desactive_7(GameObject game1, GameObject game2, GameObject game3, GameObject game4, GameObject game5, GameObject game6, GameObject game7, bool boool)
    {
        Active_Desactive_4(game1, game2, game3, game4, boool);
        Active_Desactive_3(game5, game6, game7, boool);
    }
    public static void Active_Desactive_8(GameObject game1, GameObject game2, GameObject game3, GameObject game4, GameObject game5, GameObject game6, GameObject game7, GameObject game8, bool boool)
    {
        Active_Desactive_7(game1, game2, game3, game4, game5, game6, game7, boool);
        game8.SetActive(boool);
    }

    public static void Active_Desactive_9(GameObject game1, GameObject game2, GameObject game3, GameObject game4, GameObject game5, GameObject game6, GameObject game7, GameObject game8, GameObject game9, bool boool)
    {
        Active_Desactive_8(game1, game2,game3, game4, game5, game6, game7, game8, boool);
        game9.SetActive(boool);
    }

    public static void Active_Desactive_11(GameObject game1, GameObject game2, GameObject game3, GameObject game4, GameObject game5, GameObject game6, GameObject game7, GameObject game8, GameObject game9, GameObject game10, GameObject game11, bool boool)
    {
        Active_Desactive_9(game1, game2, game3, game4, game5, game6, game7, game8,game9, boool);
        Active_Desactive_2(game10, game11, boool);
    }

}
