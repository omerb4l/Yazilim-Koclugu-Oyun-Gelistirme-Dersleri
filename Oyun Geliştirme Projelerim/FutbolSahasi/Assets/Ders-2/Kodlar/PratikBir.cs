using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class PratikBir : MonoBehaviour
{
    //CTRL + X = satir silme
    //CTRL + D = sat�r cogaltma
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
        helloWorld.text = "Merhaba D�nya!";
        //System.out.println("Oyun Ba�lad�!");
        Debug.Log("Oyun Ba�lad�!");
    }


    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime ge�en zaman� 
        // gameObject.SetActive(True/False) --> gostermemes�n� �st�yorsan bu kodu kullan
        sayac = sayac - Time.deltaTime;
        if (sayac > 0)
        {
            sayac = sayac - Time.deltaTime;
            //sayacText.text = sayac.ToString(); // mant�k hatas� olacak!
            helloWorld.text = "Ders Ba�l�yor...";
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
        }
        else if(sayac <= 0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.gameObject.SetActive(false);
            sayacArkaPlani.gameObject.SetActive(false);
            helloWorld.text = "";
            helloWorld.text = "Ders Ba�lad�!..";
        }
    }
}
