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
        dogruCevap = "Ýlham";
        if (dogruCevap == cevap)
        {
            sorununMetni.text = "Tebrikler! Soruyu doðru cevaplandýrdýrdýnýz.";
            aSikkiDogrulukResmi.color = Color.green;
            bSikkiDogrulukResmi.color = Color.white;


        }
        else
        {
            sorununMetni.text = "Maalesef! Soruyu yanlýþ cevaplandýrdýnýz.";
            aSikkiDogrulukResmi.color = Color.white;
            bSikkiDogrulukResmi.color = Color.red;
        }

    }
    public void SoruUret() {

        aSikkiDogrulukResmi.color = Color.white;
        bSikkiDogrulukResmi.color = Color.white;

        soruBasligiMetni.text = "Genel Kültür/Teknoloji";
        sorununMetni.text = "Inspimonun kelime anlamý aþaðýdakilerden hangisidir?";
        soruNumarasi = 1;
        soruNumarasiMetni.text = soruNumarasi.ToString();

        aSikkiMetni.text = "A)" + "Ýlham";
        bSikkiMetni.text = "B)" + "Ýntikam";

    }

}
