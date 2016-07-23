using UnityEngine;
using System.Collections;
using Application;

public class FactoryTouch : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		Debug.Log("OnMouseDown() tag: " + gameObject.tag);
		if (gameObject.CompareTag ("purple_jar")) { //function1
			Debug.Log("Run purple jar tag");

			string output = MachineController.ApplyFunctionToCake ("");
			Debug.Log("output: "+output);    //for testing

			GameObject spriteObject = GameObject.Find ("base_cake");
			spriteObject.transform.position += Vector3.up * 2.0F;
			Renderer renderer = spriteObject.GetComponent<Renderer> ();
			renderer.material.SetColor ("_Color", Color.magenta);
		}
		else if (gameObject.CompareTag ("green_jar")) {	//function 2
			Debug.Log("Run green jar tag");
			GameObject spriteObject = GameObject.Find ("base_cake");
			spriteObject.transform.position += Vector3.up * 2.0F;
			Renderer renderer = spriteObject.GetComponent<Renderer> ();
			renderer.material.SetColor ("_Color", Color.green);
		}
		else if (gameObject.CompareTag ("red_jar")) {	//function 3
			Debug.Log("Run red jar tag");
			GameObject spriteObject = GameObject.Find ("base_cake");
			spriteObject.transform.position += Vector3.up * 2.0F;
			Renderer renderer = spriteObject.GetComponent<Renderer> ();
			renderer.material.SetColor ("_Color", Color.red);
		}
		else if (gameObject.CompareTag ("blue_jar")) {	//function 4
			Debug.Log("Run blue jar tag");
			GameObject spriteObject = GameObject.Find ("base_cake");
			spriteObject.transform.position += Vector3.up * 2.0F;
			Renderer renderer = spriteObject.GetComponent<Renderer> ();
			renderer.material.SetColor ("_Color", Color.blue);
		}
	}

}
