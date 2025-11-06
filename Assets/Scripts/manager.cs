using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager : MonoBehaviour
{

    public TMP_Text altinGosterge;


    public bool oyunAktif=true;
    public int altinSayisi = 0;



    void Start()
    {
        
    }

    
    void Update()
    {
        altinGosterge.text = "Altýn: " + altinSayisi;
    }
}
