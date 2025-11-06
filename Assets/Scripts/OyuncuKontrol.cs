using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public manager kontrol;

    public float hýz = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (kontrol.oyunAktif == true)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hýz;
            y *= Time.deltaTime * hýz;

            transform.Translate(x, 0f, y);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("altin"))
        {
            kontrol.altinSayisi += 1;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag.Equals("engel"))
        {
            kontrol.oyunAktif = false;
        }
    }


}
