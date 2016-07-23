using UnityEngine;
using System.Collections;

public class CakeObject : MonoBehaviour {
	public string formula;

	// Use this for initialization
	void Start () {
		formula = "x"; //start with x
		Debug.Log("start: " + formula);
	}
}
