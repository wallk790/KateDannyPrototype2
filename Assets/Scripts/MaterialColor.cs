using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaterialColor : MonoBehaviour {

	public Slider blue;
	public Slider red;
	public Slider green;
	public Slider alpha;
	public Color color;
	public Renderer rend; 

	void Black(){
		color.a = rend.sharedMaterial.color.a;
		color.b = rend.sharedMaterial.color.b;
		color.g = rend.sharedMaterial.color.g;
		color.a = rend.sharedMaterial.color.a;
	}

	void Start ()
	{       
		rend = GetComponent<Renderer>();
		Black();
	}      

	void Update(){
		rend.sharedMaterial.color = color;
		color.a = alpha.value;
		color.r = red.value;
		color.g = green.value;
		color.b = blue.value;
	}



}
