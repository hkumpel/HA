using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EmpiezaJuego : MonoBehaviour {

	public GameObject martillo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
		if (Input.GetKeyDown ("m")) {
			martillo.SetActive (true);
		} else if(Input.GetKeyDown ("q")) {
			SceneManager.LoadScene ("Portada");
		}

	}
}
