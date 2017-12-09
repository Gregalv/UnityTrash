using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulatePalit : MonoBehaviour {

    public Brush brushPrefab;
    public Palit palit;
	// Use this for initialization
	void Start () {
		foreach(var sprite in palit.sprites) {
            var brush = Instantiate(brushPrefab, this.transform);
            brush.Initialize(sprite);
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
