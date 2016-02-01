using UnityEngine;
using System.Collections;

public class ParticleSortingLayerFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer renderer = GetComponent<Renderer> ();

		renderer.sortingLayerName = "Player";
		renderer.sortingOrder = -1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
