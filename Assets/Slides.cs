using UnityEngine;
using System.Collections;

public class Slides : MonoBehaviour {
	
	public Texture2D[] TheSlides;
	public float Delay = 5;
	
	private int i = 0;
	
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = TheSlides[0];
		StartCoroutine(DisplaySlides());
	}
	
	IEnumerator DisplaySlides(){
		while (true){
			yield return new WaitForSeconds(Delay);
			i++;
			if (i >= TheSlides.Length) {
				i = 0;
			}
			renderer.material.mainTexture = TheSlides[i];
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
