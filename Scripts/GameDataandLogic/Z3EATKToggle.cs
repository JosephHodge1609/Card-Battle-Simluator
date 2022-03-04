using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Z3EATKToggle : MonoBehaviour
{
    public GameObject EndTurnButtonob;
    public TextMeshProUGUI EnemyZone3AbilityusedText;


    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonob.GetComponent<EndTurnButton>();

        if (E.EnemyAbilityUsedZone3 == false)
        {
            E.EnemyAbilityUsedZone3 = true;
            EnemyZone3AbilityusedText.text = "Yes";
        }
        else if (E.EnemyAbilityUsedZone3 == true)
        {
            E.EnemyAbilityUsedZone3 = false;
            EnemyZone3AbilityusedText.text = "No";
        }

    }
}
