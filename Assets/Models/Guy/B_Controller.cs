using UnityEngine;
using System.Collections;

public class B_Controller : MonoBehaviour
{
	public GameObject serverHat;
	public Object bomb;
	public Transform throwFrom;
	GameObject currBomb;
	Vector3 start, globalEnd;
	public float bombSpeed;
	public GameObject snapFL, snapFR, snapBL, snapBR;
	GameObject curSnap;
	float time;
	bool startLoop = true;
	Rigidbody doll;
	bool xORz = false;
	bool lORg = false;
	public float speed = 1f;
	float fl = 0, fr = 1, bl = 2, br = 3;
	float snap = 2;
	void Start ()
	{
		transform.position = snapBL.transform.position;
		doll = GetComponent<Rigidbody> ();
		curSnap = snapBL;
		transform.Rotate (0f, 90f, 0f);
		//StartCoroutine (moveTo());
	}

	IEnumerator moveTo (Vector3 end)
	{
		startLoop = false;
		globalEnd = end;
//		start = transform.position;
//		Debug.Log ("Started Moving");
//		time = 0f;
//		while (time<=1f) {
//			transform.position = Vector3.Lerp (start, end, time);
//			time += 0.0005f;
//		}
//		Debug.Log ("Done Moving");
		if (Mathf.Abs (end.x - transform.position.x) > 2.5f) {
			if (end.x < transform.position.x) {
				doll.velocity = new Vector3 (speed * -1f, 0f, 0f);
				xORz = false;
				lORg = false;
				Debug.Log ("Moving in x at -1");
			}
			if (end.x > transform.position.x) {
				doll.velocity = new Vector3 (speed * 1f, 0f, 0f);
				xORz = false;
				lORg = true;
				Debug.Log ("Moving in x at 1");
			}
		}
		if (Mathf.Abs (end.z - transform.position.z) > 2.5f) {
			if (end.z < transform.position.z) {
				doll.velocity = new Vector3 (0f, 0f, speed * -1f);
				xORz = true;
				lORg = false;
				Debug.Log ("Moving in z at -1");
			}
			if (end.z > transform.position.z) {
				doll.velocity = new Vector3 (0f, 0f, speed * 1f);
				xORz = true;
				lORg = true;
				Debug.Log ("Moving in z at 1");
			}
		}
		if (xORz)
			Debug.Log ("Z");
		else
			Debug.Log ("X");
		if (lORg)
			Debug.Log ("<");
		else
			Debug.Log (">");
		GetComponent<Animator> ().SetBool ("moving", true);
		yield return null;
	}

	void attack ()
	{
		time = Time.time;
		GetComponent<Animator> ().SetBool ("attack", true);
	}

	//99 miles per hour is how fast we like to go
	void Update ()
	{ 
		if (startLoop) {
			if (GetComponent<Animator> ().GetBool ("attack"))
				GetComponent<Animator> ().SetBool ("attack", false);
			if (Input.GetMouseButton (0) && Time.time - time > 1.0f) {
				attack ();
				//currBomb = (GameObject)(Instantiate (bomb, throwFrom.position, throwFrom.rotation));
				//currBomb.GetComponent<Rigidbody> ().AddForce (0f, 100f, bombSpeed * 900f);
				//currBomb.GetComponent<bombController>().comingFrom = gameObject;
				Debug.Log ("made bomb lel");
			}
			if (Input.GetKey (KeyCode.W)) {
				if (curSnap.name == snapBR.name)
					snap = bl;
				if (curSnap.name == snapFR.name)
					snap = fl;
			}
			if (Input.GetKey (KeyCode.A)) {
				if (curSnap.name == snapFR.name)
					snap = br;
				if (curSnap.name == snapFL.name)
					snap = bl;
			}
			if (Input.GetKey (KeyCode.S)) {
				if (curSnap.name == snapBL.name)
					snap = br;
				if (curSnap.name == snapFL.name)
					snap = fr;
			}
			if (Input.GetKey (KeyCode.D)) {
				if (curSnap.name == snapBL.name)
					snap = fl;
				if (curSnap.name == snapBR.name)
					snap = fr;
			}
			if (snap == fl && curSnap.name != snapFL.name && curSnap.name != snapBR.name) {
				curSnap = snapFL;
				StartCoroutine (moveTo (snapFL.transform.position));
			}
			if (snap == fr && curSnap.name != snapFR.name && curSnap.name != snapBL.name) {
				curSnap = snapFR;
				StartCoroutine (moveTo (snapFR.transform.position));
			}
			if (snap == bl && curSnap.name != snapBL.name && curSnap.name != snapFR.name) {
				curSnap = snapBL;
				StartCoroutine (moveTo (snapBL.transform.position));
			}
			if (snap == br && curSnap.name != snapBR.name && curSnap.name != snapFL.name) {
				curSnap = snapBR;
				StartCoroutine (moveTo (snapBR.transform.position));
			}
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == curSnap.name) {
			doll.velocity = new Vector3 (0f, 0f, 0f);
			startLoop = true;
			GetComponent<Animator> ().SetBool ("moving", false);
		}
		Debug.Log (other.name);
		Debug.Log (curSnap.name);
	}
}
