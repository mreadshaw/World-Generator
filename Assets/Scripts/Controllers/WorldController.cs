using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

	World world;

	// Use this for initialization
	void Start () {
		world = new World ();
		Debug.Log("World created.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
