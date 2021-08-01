using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public GameObject Shop;
    public GameObject Openshop;
    public GameObject exitbutton;
    public void QuitShop()
    {
        Shop.SetActive(false);
        exitbutton.SetActive(false);
        Openshop.SetActive(true);
    }
    public void open()
    {
        Shop.SetActive(true);
        Openshop.SetActive(false);
        exitbutton.SetActive(true);
    }
}
