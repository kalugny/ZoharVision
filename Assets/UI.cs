using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	public Texture2D Hair;
	public Texture2D Sun;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		int SunSize = Screen.height / 10;
		GUIStyle gs = new GUIStyle();
		gs.fontSize = SunSize / 2;
		gs.alignment = TextAnchor.MiddleLeft;
		
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Hair);
		GUI.DrawTexture(new Rect(0, Screen.height - SunSize, SunSize, SunSize), Sun);
		GUI.Label(new Rect(SunSize, Screen.height - SunSize, SunSize, SunSize), "28°C", gs);
	}
}
