using UnityEngine;
using System;
using System.Linq;

namespace Application
{
	public sealed class MachineController
	{
		private static readonly MachineController instance = new MachineController();

		static MachineController() {} // Make sure it's truly lazy
		private MachineController() {} // Prevent instantiation outside

		public static MachineController Instance { get { return instance; }}
		public static CakeObject cakeOjbect = GameObject.Find("base_cake").GetComponents<CakeObject> ()[0];

		public static string ApplyFunctionToCake(string machineFunction){
			string input = cakeOjbect.formula;
			string output = machineFunction.Replace("x", input);    //apply function to input

			cakeOjbect.formula = output;    //update the function of Cake.
			return output;
		}

		public static char[] FormulaConverter(string finalFunction){
			//return new string((from c in finalFunction where char.IsLetterOrDigit(c) select c).ToArray());
			return (from c in finalFunction where char.IsLetterOrDigit(c) select c).ToArray();
		}
	}
}

