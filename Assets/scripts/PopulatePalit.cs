using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopulatePalit : MonoBehaviour
{

    public Brush brushPrefab;
    public Palit palit;

    //private float maxHeight = 0;
    //private float maxWidth = 0;

    // Use this for initialization
    void Start()
    {
        foreach (var sprite in palit.sprites)
        {
            
            var brush = Instantiate(brushPrefab, this.transform);
            brush.Initialize(sprite);
            brush.GetComponent<LayoutElement>().minHeight = brush.image.GetComponent<RectTransform>().rect.height + 10;
            brush.GetComponent<LayoutElement>().minWidth = brush.image.GetComponent<RectTransform>().rect.width + 30;
            
            //maxHeight = brush.image.GetComponent<RectTransform>().rect.height;
            // maxWidth = brush.image.GetComponent<RectTransform>().rect.width;
            // public Vector2 cellSize;

            //this.GetComponent<GridLayoutGroup>().cellSize = new Vector2(maxWidth, maxHeight);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
