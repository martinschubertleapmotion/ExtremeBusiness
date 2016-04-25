using UnityEngine;
using System.Collections;
using RootMotion.Dynamics;

namespace RootMotion.Demos {

	// Code example for picking up/dropping props.
	public class PropDemo : MonoBehaviour {

		public bool IsHolding;

		[Tooltip("The Prop you wish to pick up.")] 
		public Prop prop;

		[Tooltip("The PropRoot to connect it to.")] 
		public PropRoot connectTo;
		
		void Update () {
			if (IsHolding = true) {
				// Makes the prop root drop any existing props and pick up the newly assigned one.
				connectTo.currentProp = prop;
			}

			if (IsHolding = false) {
				// By setting the prop root's currentProp to null, the prop connected to it will be dropped.
				connectTo.currentProp = null;
			}
		}
	}
}
