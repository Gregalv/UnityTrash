using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brush : MonoBehaviour {
    public Image image;
    // Use this for initialization
    public void Initialize (Sprite sprite) {
        Debug.Log("Hello world?");
        image.sprite = sprite;
        image.SetNativeSize();
	}	
	
}
