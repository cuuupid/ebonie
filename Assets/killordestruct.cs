using UnityEngine;
using UnityEditor;
using System.Collections;

public class killordestruct : MonoBehaviour
{
	public GameObject PlayingBoard;
	// Use this for initialization
	void Start ()
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log (other.gameObject.name);
		if (other.gameObject.tag == "floor" || other.gameObject.name == "floor") {
			Debug.Log ("boom");
			gameObject.transform.parent.gameObject.SetActive (false);
			gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "B_player") {
			Debug.Log ("RESETTTTTTTTTTTT");
			GameObject.Find ("Manager").GetComponent<gamevars> ().resetField ();
		}
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
