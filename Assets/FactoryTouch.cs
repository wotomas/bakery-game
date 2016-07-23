using UnityEngine;
using System.Collections;
using Application;

public class FactoryTouch : MonoBehaviour {
	GameObject spriteObject;
	Renderer renderer;

	// Use this for initialization
	void Start () {
		spriteObject = GameObject.Find ("base_cake");
		renderer = spriteObject.GetComponent<Renderer> ();
	}

	void OnMouseDown() {
		Debug.Log("OnMouseDown() tag: " + gameObject.tag);
		if (gameObject.CompareTag ("purple_jar")) { //function1
			string output = MachineController.ApplyFunctionToCake ("x+v+A");
			char[] formulaPatternArray = MachineController.FormulaConverter (output);

			//TODO call renderer
			// CakeRenderHelper.renderCakeFromPattern(formulaPattern)


			Debug.Log("function1 output: "+output);    //for testing

			spriteObject.transform.position += Vector3.up * 2.0F;
			renderer.material.SetColor ("_Color", Color.magenta);
		}
		else if (gameObject.CompareTag ("green_jar")) {	//function 2
			string output = MachineController.ApplyFunctionToCake ("x+x+g");
			Debug.Log("function2 output: "+output);    //for testing

			spriteObject.transform.position += Vector3.up * 2.0F;
			renderer.material.SetColor ("_Color", Color.green);
		}
		else if (gameObject.CompareTag ("red_jar")) {	//function 3
			string output = MachineController.ApplyFunctionToCake ("x+p+x+B");
			Debug.Log("function3 output: "+output);    //for testing

			spriteObject.transform.position += Vector3.up * 2.0F;
			renderer.material.SetColor ("_Color", Color.red);
		}
		else if (gameObject.CompareTag ("blue_jar")) {	//function 4
			string output = MachineController.ApplyFunctionToCake ("xb+xb");
			Debug.Log("function4 output: "+output);    //for testing

			spriteObject.transform.position += Vector3.up * 2.0F;
			renderer.material.SetColor ("_Color", Color.blue);
		}
	}
}
