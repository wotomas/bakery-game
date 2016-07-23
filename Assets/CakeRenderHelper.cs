using UnityEngine;
using System;
using System.Linq;

namespace AssemblyCSharp
{
	public sealed class CakeRenderHelper
	{
		private static readonly CakeRenderHelper instance = new CakeRenderHelper();

		static CakeRenderHelper() {} // Make sure it's truly lazy	
		private CakeRenderHelper() {} // Prevent instantiation outside

		public static CakeRenderHelper Instance { get { return instance; }}
		public static CakeObject cakeOjbect = GameObject.Find("base_cake").GetComponents<CakeObject> ()[0];
	}
}

