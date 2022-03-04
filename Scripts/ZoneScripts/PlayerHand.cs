using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerHand : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData EventData)
    {

    }
    public void OnPointerExit(PointerEventData EventData)
    {

    }
    public void OnDrop(PointerEventData EventData)
    {
        
        DraggingCards D = EventData.pointerDrag.GetComponent<DraggingCards>();
        if (D != null)
        {
            D.ReturntoOriginalPlacement = transform;
            Debug.Log(EventData.pointerDrag.name + " was dropped on " + gameObject.name);
        }

    }
}
