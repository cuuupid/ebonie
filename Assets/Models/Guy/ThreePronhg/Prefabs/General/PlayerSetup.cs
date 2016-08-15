using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour
{
/*
	public Camera main;
	public GameObject[] bodyParts;
	public Material one;
	public Material two;
	public Material three;
	// Use this for initialization
	void Start ()
	{
		if (!isLocalPlayer) {
			gameObject.GetComponent<B_Controller> ().snapFR = GameObject.Find ("R_BL");
			gameObject.GetComponent<B_Controller> ().snapFL = GameObject.Find ("R_BR");
			gameObject.GetComponent<B_Controller> ().snapBR = GameObject.Find ("R_FL");
			gameObject.GetComponent<B_Controller> ().snapBL = GameObject.Find ("R_FR");
			Debug.Log ("I am not a local player!");
			gameObject.transform.position = gameObject.GetComponent<B_Controller> ().snapBR.transform.position;
			gameObject.GetComponent<B_Controller> ().bombSpeed = -1f;
			GetComponent<B_Controller> ().serverHat.SetActive (false);
			gameObject.name = "Not Local Player or Not Server";
		}
		if (isLocalPlayer) {
			GetComponent<B_Controller> ().enabled = true;
			gameObject.GetComponent<B_Controller> ().snapFR = GameObject.Find ("B_FR");
			gameObject.GetComponent<B_Controller> ().snapFL = GameObject.Find ("B_FL");
			gameObject.GetComponent<B_Controller> ().snapBR = GameObject.Find ("B_BR");
			gameObject.GetComponent<B_Controller> ().snapBL = GameObject.Find ("B_BL");
			//	main.gameObject.SetActive(true);
			//	main.transform.position = new Vector3(9f,10f,5f);
			//	main.transform.rotation = GameObject.Find ("Main Camera (2)").transform.rotation;
			//	main.gameObject.GetComponent<cameraManager>().x = GameObject.Find ("Main Camera (2)").transform;
			//	GameObject.Find ("Main Camera (2)").SetActive(false);
			gameObject.name = "Local Player";
		}
		if ((!isServer && isLocalPlayer) || (isServer && !isLocalPlayer)) {
			gameObject.GetComponent<B_Controller> ().snapFR = GameObject.Find ("R_BL");
			gameObject.GetComponent<B_Controller> ().snapFL = GameObject.Find ("R_BR");
			gameObject.GetComponent<B_Controller> ().snapBR = GameObject.Find ("R_FL");
			gameObject.GetComponent<B_Controller> ().snapBL = GameObject.Find ("R_FR");
			gameObject.transform.position = gameObject.GetComponent<B_Controller> ().snapBR.transform.position;
			gameObject.GetComponent<B_Controller> ().bombSpeed = -1f;
//			((GameObject)gameObject.GetComponent<B_Controller> ().bomb).GetComponent<MeshRenderer>().material = one;
//			((GameObject)gameObject.GetComponent<B_Controller>().bomb).GetComponent<bombController>().friendorfoe = true;
//			GetComponent<B_Controller> ().serverHat.SetActive (false);
			gameObject.name = "Not Local Player or Not Server";
			for (int i = 0; i<bodyParts.Length; i++) {
				Debug.Log ("Replaced material " + bodyParts [i].GetComponent<MeshRenderer> ().materials [0].name);
				if (bodyParts [i].GetComponent<MeshRenderer> ().materials [0].name == "Blue Three (Instance)") {
					bodyParts [i].GetComponent<MeshRenderer> ().material = three;
					Debug.Log ("with " + bodyParts [i].GetComponent<MeshRenderer> ().materials [0].name);
				} else if (bodyParts [i].GetComponent<MeshRenderer> ().materials [0].name == "Blue Two (Instance)") {
					bodyParts [i].GetComponent<MeshRenderer> ().material = two;
				} else if (bodyParts [i].GetComponent<MeshRenderer> ().materials [0].name == "Blue One (Instance)") {
					bodyParts [i].GetComponent<MeshRenderer> ().material = one;
				} else
					Debug.Log ("Didn't match name");
			}
			gameObject.tag = "R_player";
		}
		if (isServer) {
			gameObject.GetComponent<B_Controller> ().bombSpeed = 1f;
			GetComponent<B_Controller> ().serverHat.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}*/
}
