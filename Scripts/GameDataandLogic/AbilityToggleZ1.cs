using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AbilityToggleZ1 : MonoBehaviour
{
    public GameObject EndTurnButtonOb;
    public TextMeshProUGUI HeroZone1AbilityusedText;

    
    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonOb.GetComponent<EndTurnButton>();
        
        if (E.AbilityUsedZone1 == false)
        {
            E.AbilityUsedZone1 = true;
            HeroZone1AbilityusedText.text = "Yes";
        }
        else if (E.AbilityUsedZone1 == true)
        {
            E.AbilityUsedZone1 = false;
            HeroZone1AbilityusedText.text = "No";
        }

    }
}
