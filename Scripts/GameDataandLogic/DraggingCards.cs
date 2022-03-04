using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DraggingCards : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] public RectTransform dragRectTransform;
    public Transform ReturntoOriginalPlacement = null;
    public void Awake()
    {
        dragRectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData EventData)
    {
        ReturntoOriginalPlacement = transform.parent;
        transform.SetParent(transform.root);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData EventData)
    {
        transform.position = EventData.position;
        dragRectTransform.SetAsLastSibling();
    }
    public void OnEndDrag(PointerEventData EventData)
    {
        transform.SetParent(ReturntoOriginalPlacement);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
   
}
