using UnityEngine;
using System.Collections;

public class twodhorror : MonoBehaviour
{
	public GameObject gameboard;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		gameboard.transform.Translate (0.0f, 0.0f, 1.0f);
	}
}
