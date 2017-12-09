using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggble : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler {
    private bool touched = false;
    Vector3 startPos;
    Transform startParent;
    private object panelRectTransform;

    public void OnBeginDrag(PointerEventData eventData)

        
       {
        startPos = transform.position;
        startParent = transform.parent;
        if (!touched) {
            touched = true;
            Instantiate(gameObject, transform.parent);        
            
            // startParent = transform.parent;
        }
        transform.localScale = Vector3.one * 1.3f;
        transform.SetAsLastSibling();
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        //        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        transform.position = eventData.position;
        
        

  //    throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //   transform.localScale = Vector3.one;
        //    throw new System.NotImplementedException();
        if (transform.position.x <= 150)
        {
            Destroy(gameObject);
        }
        //transform.gameObject.SetAsFirstSibling;
        
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
