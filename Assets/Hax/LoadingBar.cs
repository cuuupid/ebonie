using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
	public RectTransform bar;
	public float max = -15.0f;
	public bool trigger = false;
	public MonoBehaviour triggerScript;
	public MonoBehaviour secondTriggerScript;
	// Use this for initialization
	void Start ()
	{
	
	}

	public void Trigger ()
	{
		trigger = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (bar.offsetMax.x < -1.0f * max && !trigger) {
			bar.offsetMax = new Vector2 (bar.offsetMax.x + 3.0f, bar.offsetMax.y);
			//	Debug.Log ("Loading Bar/" + bar.offsetMax.x);
		}
		if (bar.offsetMax.x >= -1.0f * max) {
			if (secondTriggerScript)
				secondTriggerScript.SendMessage ("Trigger");
			triggerScript.SendMessage ("Trigger");
		}
	}
}
