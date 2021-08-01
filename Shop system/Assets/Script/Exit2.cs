using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit2 : MonoBehaviour
{
    public GameObject Shop2;
    public GameObject Openshop2;
    public GameObject exitbutton2;
    public GameObject SkillShopButton;
    public void QuitShop()
    {
        Shop2.SetActive(false);
        exitbutton2.SetActive(false);
        Openshop2.SetActive(true);
        SkillShopButton.SetActive(true);
    }
    public void open()
    {
        Shop2.SetActive(true);
        Openshop2.SetActive(false);
        SkillShopButton.SetActive(false);
        exitbutton2.SetActive(true);
    }
}
