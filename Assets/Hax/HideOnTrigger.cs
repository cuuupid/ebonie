using UnityEngine;
using System.Collections;

public class HideOnTrigger : MonoBehaviour
{
	public GameObject[] linked;
	// Use this for initialization
	void Start ()
	{
	
	}

	void Trigger ()
	{
		if (linked.Length > 0)
			for (int i = 0; i<linked.Length; i++)
				linked [i].SetActive (false);
		gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
