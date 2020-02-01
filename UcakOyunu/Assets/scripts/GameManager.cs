using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float hiz,yukselisHizi;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(hiz * Time.deltaTime, 0, 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * yukselisHizi);
        }

	}
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag == "gecis")
        {
            nesne.gameObject.transform.root.gameObject.GetComponent<Yol>().aktif = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D nesne)
    {
        if(nesne.gameObject.tag=="Engel")
        {
            Time.timeScale = 0;  //oyunu durdur
        }
    }
}
