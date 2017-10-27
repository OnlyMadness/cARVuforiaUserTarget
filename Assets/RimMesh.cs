using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var rim2 = GameObject.FindGameObjectsWithTag("2");
        rim2[1].GetComponent<MeshRenderer>().enabled = false;
        //gameObject.GetComponent<MeshRenderer>().enabled = false;
        Debug.Log("qwe");
            
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
