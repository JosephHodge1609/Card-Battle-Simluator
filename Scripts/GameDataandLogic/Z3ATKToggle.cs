using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Z3ATKToggle : MonoBehaviour
{
    public GameObject EndTurnButtonob;
    public TextMeshProUGUI BattleZone3AbilityusedText;


    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonob.GetComponent<EndTurnButton>();

        if (E.AbilityUsedZone3 == false)
        {
            E.AbilityUsedZone3 = true;
            BattleZone3AbilityusedText.text = "Yes";
        }
        else if (E.AbilityUsedZone3 == true)
        {
            E.AbilityUsedZone3 = false;
            BattleZone3AbilityusedText.text = "No";
        }

    }
}
