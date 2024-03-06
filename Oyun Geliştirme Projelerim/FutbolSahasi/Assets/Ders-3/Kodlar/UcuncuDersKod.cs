using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UcuncuDersKod : MonoBehaviour
{
    // Start is called before the first frame update

    public Text soruBasligiMetni;
    public Text sorununMetni;
    public int soruNumarasi;
    public Text soruNumarasiMetni;

    public Text aSikkiMetni;
    public Text bSikkiMetni;

    public string dogruCevap;

    public Image aSikkiDogrulukResmi;
    public Image bSikkiDogrulukResmi;

    private void Start()
    {
        SoruUret();
    }

    // Update is called once per frame
    private void Update()
    {

        if (true)
        {

        }




    }

    public void DogrulukKontrolu(string cevap)
    {
        dogruCevap = "�lham";
        if (dogruCevap == cevap)
        {
            sorununMetni.text = "Tebrikler! Soruyu do�ru cevapland�rd�rd�n�z.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;


        }
        else
        {
            sorununMetni.text = "Maalesef! Soruyu yanl�� cevapland�rd�n�z.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }

    }
    public void SoruUret() {

        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;

        soruBasligiMetni.text = "Genel K�lt�r/Teknoloji";
        sorununMetni.text = "Inspimonun kelime anlam� a�a��dakilerden hangisidir?";
        soruNumarasi = 1;
        soruNumarasiMetni.text = soruNumarasi.ToString();

        aSikkiMetni.text = "A)" + "�lham";
        bSikkiMetni.text = "B)" + "�ntikam";

    }

}
