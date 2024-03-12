using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {

	public GameObject myGameObject = null;
	// Use this for initialization
	void Start () {

		myGameObject = Instantiate(Resources.Load("Prefabs/Cloud")) as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
