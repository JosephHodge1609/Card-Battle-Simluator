using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Z2ATKtoggle : MonoBehaviour
{
    public GameObject EndTurnButtonob;
    public TextMeshProUGUI BattleZone2AbilityusedText;


    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonob.GetComponent<EndTurnButton>();

        if (E.AbilityUsedZone2 == false)
        {
            E.AbilityUsedZone2 = true;
            BattleZone2AbilityusedText.text = "Yes";
        }
        else if (E.AbilityUsedZone2 == true)
        {
            E.AbilityUsedZone2 = false;
            BattleZone2AbilityusedText.text = "No";
        }

    }
}
