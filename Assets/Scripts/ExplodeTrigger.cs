using UnityEngine;
using System.Collections;

public class ExplodeTrigger : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}

	void Trigger ()
	{
		GameObject.Find ("Manager").GetComponent<gamevars> ().nextLevel ();
		gameObject.SendMessage ("Explode");
		gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
