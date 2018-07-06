using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityEventDemo : MonoBehaviour {
	#region PUBLIC_VERIABLE
	public Text demoText;
	#endregion
	#region PRIVATE_VARIABLE
	int initialSize=10;
	int maxSize=100 ;
	#endregion
	#region UNITY_CALLBACKS
	void start(){
	}
	#endregion
	#region PUBLIC_VARIABLE
	public void TextChange(){
		StartCoroutine (WaitAndChangeText (1));
	}
	#endregion
	#region CO_ROUTINE
	IEnumerator WaitAndChangeText(float time){
		float i = 0;
		float rate = 1 / time;
		while (i < 1) {
			i += Time.deltaTime * rate;
			demoText.resizeTextMaxSize = (int)Mathf.Lerp (initialSize, maxSize, i);
			yield return new WaitForSeconds (0.01f);
		}
	}
	#endregion

}
