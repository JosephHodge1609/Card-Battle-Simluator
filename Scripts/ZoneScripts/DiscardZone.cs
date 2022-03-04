using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscardZone : MonoBehaviour, IDropHandler
{
   
   
    public void OnDrop(PointerEventData EventData)
    {
        DraggingCards D = EventData.pointerDrag.GetComponent<DraggingCards>();
        if (D != null)
        {
            D.ReturntoOriginalPlacement = transform;
        }
        Destroy(D.gameObject);
    }

    }
