using UnityEngine;
using System.Collections;
using RootMotion.Dynamics;

namespace RootMotion.Demos {

	// Code example for picking up/dropping props.
	public class PropDrop : MonoBehaviour {

		public bool IsHolding;

		[Tooltip("The Prop you wish to pick up.")] 
		public Prop prop;

		[Tooltip("The PropRoot to connect it to.")] 
		public PropRoot connectTo;
		
		void Update () {
			
			if (IsHolding = false) {
				// By setting the prop root's currentProp to null, the prop connected to it will be dropped.
				connectTo.currentProp = null;
			}
		}
	}
}
