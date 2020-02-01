using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour {
    public Transform ucak;
    public float xdegeri;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(ucak.position.x + xdegeri, 0,-10);
	}
}
