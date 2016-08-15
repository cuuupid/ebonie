using UnityEngine;
using System.Collections;

public class worldmaker : MonoBehaviour
{
	public GameObject cam;
	public GameObject chara;
	public GameObject fps;
	// Use this for initialization
	void Start ()
	{
		fps.SetActive (false);
		chara.SetActive (true);
		cam.SetActive (true);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
