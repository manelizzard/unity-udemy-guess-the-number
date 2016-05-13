﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Load level requested for: " + name);
	}

	public void QuitRequest() {
		Debug.Log ("Quit request");
	}
}
