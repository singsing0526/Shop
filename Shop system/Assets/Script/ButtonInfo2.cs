using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo2 : MonoBehaviour
{
    public int ItemID;
    public Text PriceTxt;
    public Text QuantitysTxt;
    public Text Itemdis;
    public GameObject SkillShopManager;


    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = "Price: $" + SkillShopManager.GetComponent<SkillShopManagerScript>().skillshopItems[2, ItemID].ToString();
        QuantitysTxt.text = SkillShopManager.GetComponent<SkillShopManagerScript>().skillshopItems[3, ItemID].ToString();

    }
}
