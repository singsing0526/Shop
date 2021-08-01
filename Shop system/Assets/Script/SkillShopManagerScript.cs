using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillShopManagerScript : MonoBehaviour
{
    public int[,] skillshopItems = new int[6, 6];
    public float coinss;
    public Text ConinssTXT;





    void Start()
    {
        ConinssTXT.text = "Coins: " + coinss.ToString();

        //IDs
        skillshopItems[1, 1] = 1;
        skillshopItems[1, 2] = 2;
        skillshopItems[1, 3] = 3;
        skillshopItems[1, 4] = 4;
        skillshopItems[1, 5] = 5;

        //price
        skillshopItems[2, 1] = 100;
        skillshopItems[2, 2] = 200;
        skillshopItems[2, 3] = 200;
        skillshopItems[2, 4] = 300;
        skillshopItems[2, 5] = 300;

        //quantity
        skillshopItems[3, 1] = 0;
        skillshopItems[3, 2] = 0;
        skillshopItems[3, 3] = 0;
        skillshopItems[3, 4] = 0;
        skillshopItems[3, 5] = 0;

    }

    public void Buy()
    {
        GameObject ButtonRefs2 = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coinss >= skillshopItems[2, ButtonRefs2.GetComponent<ButtonInfo2>().ItemID]) ;
        {
            coinss -= skillshopItems[2, ButtonRefs2.GetComponent<ButtonInfo2>().ItemID];
            skillshopItems[3, ButtonRefs2.GetComponent<ButtonInfo2>().ItemID]++;
            ConinssTXT.text = "Coins: " + coinss.ToString();
            ButtonRefs2.GetComponent<ButtonInfo2>().QuantitysTxt.text = skillshopItems[3, ButtonRefs2.GetComponent<ButtonInfo2>().ItemID].ToString();
        }
    }

}
