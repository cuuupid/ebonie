using UnityEngine;
using UnityEditor;
using System.Collections;

public class Teleporter : MonoBehaviour
{
	public GameObject to;
	public GameObject cutscene;
	public MonoBehaviour triggerScript;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
			Teleport (other.gameObject);
	}

	void Teleport (GameObject player)
	{
		Debug.Log ("teleporting");
		player.transform.position = to.transform.position;
		GameObject Thingy = (GameObject)Instantiate (cutscene, new Vector3 (0.0f, 0.0f, 0.0f), new Quaternion (0.0f, 0.0f, 0.0f, 0.0f));
//		Thingy.GetComponent<RectTransform> ().anchoredPosition3D = new Vector3 (355.5f, 346.5f, 0.0f);
//		Debug.Log (Thingy.GetComponent<RectTransform> ().anchoredPosition3D);
		PrefabUtility.ResetToPrefabState (Thingy);
		Thingy.transform.parent = GameObject.FindGameObjectWithTag ("Canvas").transform;
		Thingy.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
		Thingy.GetComponentInChildren<LoadingBar> ().secondTriggerScript = triggerScript;
	}

}
