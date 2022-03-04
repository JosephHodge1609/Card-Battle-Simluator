using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class BattleZoneOne : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI Zone1HeroHealth;
    public TextMeshProUGUI Zone1HeroPhysicalDefense;
    public TextMeshProUGUI Zone1HeroMagicalDefense;
    public TextMeshProUGUI Zone1HeroRangedDefense;
    public TextMeshProUGUI Zone1HeroBasicDamage;
    public TextMeshProUGUI Zone1HeroStamina;
    public TextMeshProUGUI Zone1HeroEffectCounter;
    public void OnPointerEnter(PointerEventData EventData)
    {

    }
    public void OnPointerExit(PointerEventData EventData)
    {

    }
    
    public void OnDrop(PointerEventData EventData)
    {
        
        Debug.Log(EventData.pointerDrag.name + " was dropped on " + gameObject.name);
       
        switch (EventData.pointerDrag.name)
        {
            case "Lone Archer(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "0";
                Zone1HeroMagicalDefense.text = "0";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Lone Paladin(Clone)":
                Zone1HeroHealth.text = "5";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "1";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Lone Knight(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "0";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Lone Mage(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "0";
                Zone1HeroMagicalDefense.text = "3";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Lone Cleric(Clone)":
                Zone1HeroHealth.text = "4";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Ember Soldier(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Crimson Assassin(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "0";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Cecillia(Clone)":
                Zone1HeroHealth.text = "5";
                Zone1HeroPhysicalDefense.text = "0";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Emblem Wizard(Clone)":
                Zone1HeroHealth.text = "5";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "2";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "3";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Flame Huntress(Clone)":
                Zone1HeroHealth.text = "4";
                Zone1HeroPhysicalDefense.text = "0";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Doranyx(Clone)":
                Zone1HeroHealth.text = "4";
                Zone1HeroPhysicalDefense.text = "2";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "2";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Pyro Sentinel(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "2";
                Zone1HeroMagicalDefense.text = "0";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "1";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Ashir(Clone)":
                Zone1HeroHealth.text = "8";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "2";
                Zone1HeroRangedDefense.text = "1";
                Zone1HeroBasicDamage.text = "1";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
            case "Dread Mermaid(Clone)":
                Zone1HeroHealth.text = "3";
                Zone1HeroPhysicalDefense.text = "1";
                Zone1HeroMagicalDefense.text = "1";
                Zone1HeroRangedDefense.text = "0";
                Zone1HeroBasicDamage.text = "1";
                Zone1HeroStamina.text = "0";
                Zone1HeroEffectCounter.text = "0";
                break;
        }



        DraggingCards D = EventData.pointerDrag.GetComponent<DraggingCards>();
        if (D != null)
        {
            D.ReturntoOriginalPlacement = transform;
        }

    }
    
}
