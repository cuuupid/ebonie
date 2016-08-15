using UnityEngine;
using System.Collections;

public class gamevars : MonoBehaviour
{
	public GameObject playingfield;
	Vector3[] transforms;
	public float level = 0;
	public GameObject twod;
	// Use this for initialization
	void Start ()
	{
		transforms = new Vector3[playingfield.GetComponentsInChildren<Transform> ().Length];
		for (int i = 0; i<playingfield.GetComponentsInChildren<Transform>().Length; i++)
			transforms [i] = new Vector3 (playingfield.GetComponentsInChildren<Transform> () [i].localPosition.x, playingfield.GetComponentsInChildren<Transform> () [i].localPosition.y, playingfield.GetComponentsInChildren<Transform> () [i].localPosition.z);
	}

	public void resetField ()
	{
		for (int i = 0; i<playingfield.GetComponentsInChildren<Transform>().Length; i++) {
			playingfield.GetComponentsInChildren<Transform> () [i].gameObject.SetActive (true);
			playingfield.GetComponentsInChildren<Transform> () [i].localPosition = transforms [i];
		}
	}

	public void nextLevel ()
	{
		level = level + 1;
		if (level == 1)
			twod.SetActive (true);
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
