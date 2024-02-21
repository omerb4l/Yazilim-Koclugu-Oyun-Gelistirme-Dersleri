using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class PratikBir : MonoBehaviour
{
    //CTRL + X = satir silme
    //CTRL + D = satýr cogaltma
    /*
     * TOPLU YORUM SATIRI
     */
    // bool = boolean

    Text yazi;
    Camera camera;
    Light light;
    VisualEffect effect;

    public Text helloWorld;
    public Text sayacText;

    public Image sayacArkaPlani;
    public Image sayacResmi;

    public float sayac = 10;

    void Start()
    {
        helloWorld.text = "Merhaba Dünya!";
        //System.out.println("Oyun Baþladý!");
        Debug.Log("Oyun Baþladý!");
    }


    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime geçen zamaný 
        // gameObject.SetActive(True/False) --> gostermemesýný ýstýyorsan bu kodu kullan
        sayac = sayac - Time.deltaTime;
        if (sayac > 0)
        {
            sayac = sayac - Time.deltaTime;
            //sayacText.text = sayac.ToString(); // mantýk hatasý olacak!
            helloWorld.text = "Ders Baþlýyor...";
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
        }
        else if(sayac <= 0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.gameObject.SetActive(false);
            sayacArkaPlani.gameObject.SetActive(false);
            helloWorld.text = "";
            helloWorld.text = "Ders Baþladý!..";
        }
    }
}
