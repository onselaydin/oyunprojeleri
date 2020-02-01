using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform aktifSetler, pasifSetler;
    private Transform randomSet;
    public float karakterHiz;
    // scriptin il saniyelerinde çalışan bir methoddur.Ekran görünmeden yapılacak işlemler
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () //Burada ekran göründüğünde yapılacak işlemler yeralmakta.
    {
        //aktifSetler.GetChild(0);
       StartCoroutine( CheckForVisibilty());
        StartCoroutine(Move());
	}
	
	// Update is called once per frame
	void Update () // Bu methodda sürekli çalışan kodları içinde barındırır.
    {
		
	}

    void Recycle()
    {
        randomSet = pasifSetler.GetChild(Random.Range(0, pasifSetler.childCount));
        randomSet.parent = aktifSetler;
        randomSet.SetAsLastSibling();
        randomSet.localPosition = aktifSetler.GetChild(aktifSetler.childCount - 2).localPosition + new Vector3(0, 8, 0);

        randomSet = aktifSetler.GetChild(0);
        randomSet.parent = pasifSetler;
        randomSet.localPosition = pasifSetler.GetChild(0).localPosition;

    }
    IEnumerator CheckForVisibilty()
    {
        while(true)
        {
            yield return new WaitForEndOfFrame();//WaitForSeconds(5);//5 sn bekle
            if (aktifSetler.GetChild(0).GetChild(1).GetComponent<SpriteRenderer>().isVisible == false)
            {
                Recycle();
            }
        }
    }

    IEnumerator Move()
    {
        while(true)
        {
            karakterHiz = karakterHiz + Time.deltaTime;//Her geçen saniye platform dahada hızlanacak :)
            Camera.main.transform.Translate(Vector2.up * (karakterHiz/10) * Time.deltaTime);
            yield return null;
        }
    }
}
