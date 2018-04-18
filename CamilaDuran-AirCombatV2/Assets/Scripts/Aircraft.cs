using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0f, 0f, 0.3f);

		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0, 8, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0, -8, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-8, 0, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (8, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);

			missile.transform.SetParent (this.gameObject.transform);

			missile.transform.localPosition = new Vector3 (0.31427f, 68.415f, 10.3f);

			missile.transform.SetParent (null);
		}
	}
}
