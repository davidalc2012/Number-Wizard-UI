using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Levl load request for: "+name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit request");
	}
}
