using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField]
    private AudioSource WrongMove;

    [SerializeField]
    private GameObject RightPanel;
    private GameObject itemBeingDragged;
    
    public static Vector2 startPosition;
    Transform startParent;


    public void OnBeginDrag(PointerEventData eventData)
    {
        //set the itemBeingDragged variable to the current gameobject
        itemBeingDragged = gameObject;
        //set the start position of the gameobject being dragged
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        transform.localScale = new Vector2(2f, 2f);
        RightPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // Debug.Log("End Drag");
        // itemBeingDragged = null;
        // transform.position = startPosition;

         if (transform.parent == startParent)
          {
              transform.position = startPosition;
            transform.localScale = new Vector2(1f, 1f);
            if (WrongMove.enabled == true)
            {
                WrongMove.Play();
            }
        }
          GetComponent<CanvasGroup>().blocksRaycasts = true;
        RightPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        
    }
}
