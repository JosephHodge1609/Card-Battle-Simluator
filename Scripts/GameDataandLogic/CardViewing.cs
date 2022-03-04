using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CardViewing : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

   public GameObject ZoomCard;

    void Start()
    {
       
    }

 

    

    public void OnPointerEnter(PointerEventData EventData)
    {
        
        GameObject BattleZone1 = GameObject.Find("BattleZone1");
        GameObject Canvas = GameObject.Find("Canvas");
        ZoomCard = Instantiate(gameObject, new Vector2(125, 405), Quaternion.identity);
        ZoomCard.transform.SetParent(Canvas.transform, false);
        RectTransform Rect = ZoomCard.GetComponent<RectTransform>();
        Rect.sizeDelta = new Vector2(250, 315);
    }

    public void OnPointerExit(PointerEventData EventData)
    {
        Destroy(ZoomCard);
    }
}
