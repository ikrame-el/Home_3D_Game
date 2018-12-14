using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfficherCatalogue : MonoBehaviour
{
    //tableau de menu
    public GameObject menu_furniture;

    //boutons pour les differentes pieces
    public GameObject bedRoom;
    public GameObject livingRoom;
    public GameObject bathRoom;
    public GameObject kitchen;
    public GameObject garden;
    public GameObject TableChaise;
    public GameObject door;
    public GameObject window;


    //les boutons pour les panels 
    public GameObject panelFurniture;
    public GameObject panelBedRoom;
    public GameObject panelLivingRoom;
    public GameObject panelBathRoom;
    public GameObject panelKitchen;
    public GameObject panelGarden;
    public GameObject panelTable_chaise;
    public GameObject panelDoor;
    public GameObject panelWindow;

    //
    private string button_pressed;

    bool isPressed = false;

    public void AfficherPieces()
    {
        button_pressed = this.gameObject.name;
        isPressed = !isPressed;
        if (isPressed)
        {
            Utils_.Active_Desactive_9(bedRoom, livingRoom, bathRoom, kitchen, garden, TableChaise, door, window,menu_furniture, true);
        }
        else
        {
            Utils_.Active_Desactive_9(bedRoom, livingRoom, bathRoom, kitchen, garden, TableChaise, door, window, menu_furniture, false);
            Utils_.Active_Desactive_9(panelWindow, panelBathRoom, panelKitchen, panelLivingRoom, panelDoor, panelTable_chaise, panelGarden, panelBedRoom, panelFurniture, false);
        }
    }

    public void Bed_down()
    {
        button_pressed = panelBedRoom.name;
    }
    public void Living_down()
    {
        button_pressed = panelLivingRoom.name;
    }
    public void Bath_down()
    {
        button_pressed = panelBathRoom.name;
    }
    public void Kitchen_down()
    {
        button_pressed = panelKitchen.name;
    }
    public void Garden_down()
    {
        button_pressed = panelGarden.name;
    }
    public void Table_Chair_down()
    {
        button_pressed = panelTable_chaise.name;
    }
    public void Storage_down()
    {
        button_pressed = panelWindow.name;
    }
    public void Door_down()
    {
        button_pressed = panelDoor.name;
    }



    private void Update()
    {
        if (button_pressed != null)
        {
            switch (button_pressed)
            {
                case "bedroom_sprites":
                    Utils_.Active_Desactive_2(panelBedRoom, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelLivingRoom, panelDoor, panelTable_chaise, panelGarden, panelWindow, false);
                    break;
                case "bathroom_sprites":
                    Utils_.Active_Desactive_2(panelBathRoom, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBedRoom, panelKitchen, panelLivingRoom, panelDoor, panelTable_chaise, panelGarden, panelWindow, false);
                    break;
                case "livingroom_sprites":
                    Utils_.Active_Desactive_2(panelLivingRoom, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelBedRoom, panelDoor, panelTable_chaise, panelGarden, panelWindow, false);
                    break;
                case "kitchen_sprites":
                    Utils_.Active_Desactive_2(panelKitchen, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelBedRoom, panelLivingRoom, panelDoor, panelTable_chaise, panelGarden, panelWindow, false);
                    break;
                case "garden_sprites":
                    Utils_.Active_Desactive_2(panelGarden, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelLivingRoom, panelDoor, panelTable_chaise, panelBedRoom, panelWindow, false);
                    break;
                case "storage_sprites":
                    Utils_.Active_Desactive_2(panelWindow, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelLivingRoom, panelDoor, panelTable_chaise, panelGarden, panelBedRoom, false);
                    break;
                case "door_sprites":
                    Utils_.Active_Desactive_2(panelDoor, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelLivingRoom, panelBedRoom, panelTable_chaise, panelGarden, panelWindow, false);
                    break;
                case "table_chair_sprites":
                    Utils_.Active_Desactive_2(panelTable_chaise, panelFurniture, true);
                    Utils_.Active_Desactive_7(panelBathRoom, panelKitchen, panelLivingRoom, panelDoor, panelBedRoom, panelGarden, panelWindow, false);
                    break;
            }
           
        }
    }
}

