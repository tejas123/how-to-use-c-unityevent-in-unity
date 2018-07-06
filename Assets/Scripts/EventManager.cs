using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour {

	#region PUBLIC_VARIABLES
	public static EventManager Instance;
	public UnityEvent testEvent;
	#endregion

	#region UNITY_CALLBACKS
	void Awake(){
		Instance = this;
	}
	void Start(){
		StartCoroutine (TestEventDemo() );
	}
	#endregion

	#region CO_ROUTINES
	IEnumerator TestEventDemo(){
		yield return new WaitForSeconds(1f);
		testEvent.Invoke ();
	}
	#endregion
}
