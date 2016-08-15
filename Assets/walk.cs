using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour
{
	public bool playable = false;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playable) {
			if (Input.GetKey (KeyCode.A))
				transform.Translate (5.0f, 0.0f, 0.0f);
			if (Input.GetKey (KeyCode.D))
				transform.Translate (-5.0f, 0.0f, 0.0f);
		}
	}
}
