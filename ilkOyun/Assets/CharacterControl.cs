using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector2(h * Time.deltaTime*5,0));
	}


    //eklediğimiz collisionlara çarptığında bu fonksiyon çalışacak.
    private void OnCollisionEnter2D(Collision2D coll)
    {
        // if(coll.gameObject)  // çarptığı objeyi alabiliriz.
        //coll.contacts //çarpışma noktası
        //print("Çarpışma oldu.");
        //çarpışma olunca oyunu yeniden başlatacağız.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
