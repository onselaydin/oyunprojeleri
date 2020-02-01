using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yol : MonoBehaviour {
    public bool aktif;
    public GameObject[] objeler;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (aktif)
        {
            objeler[3].SetActive(false);  //yıldızı gizle
            Invoke("YoluTasi", 4); //4 saniye sonra.
            aktif = false;
        }
    }

    void YoluTasi()
    {
        float altsayi = Random.Range(0, 2);
        float ustsayi = Random.Range(0, 2);

        if(altsayi==1)
        {
            objeler[1].SetActive(false);//altdiken gizle
        }
        else
        {
            objeler[1].SetActive(true);//altdiken göster.
        }

        if (ustsayi == 1)
        {
            objeler[2].SetActive(false);//altdiken gizle
        }
        else
        {
            objeler[2].SetActive(true);//altdiken göster.
        }

        objeler[0].transform.localPosition = new Vector2(Random.Range(-3.4f, 3.4f),0);//dikenleri
        transform.position = transform.position + new Vector3(40.379f, 0, 0);
        objeler[3].SetActive(true);
    }
}
