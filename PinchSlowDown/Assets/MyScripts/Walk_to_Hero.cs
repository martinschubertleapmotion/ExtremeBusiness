using UnityEngine;
using System.Collections;

public class Walk_to_Hero : MonoBehaviour {
	public NavMeshAgent agent;
	public Vector3 destination;
	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () 
	{
		//////////////////////////////////////////////////////////////////////////////////////////
		//You don't have to include this one line code:
		//I included this line to correct my enemy's rotation, you might not need this one line.
		//Or you may have to change the rotation to fit your character.
		//////////////////////////////////////////////////////////////////////////////////////////
		agent.destination = destination;
//		Internal_Nav_Mesh_Agent.SetDestination (Object_to_Walk_to.transform.position);
	}
}

