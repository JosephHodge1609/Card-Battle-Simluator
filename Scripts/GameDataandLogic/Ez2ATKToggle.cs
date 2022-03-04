using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ez2ATKToggle : MonoBehaviour
{
    public GameObject EndTurnButtonob;
    public TextMeshProUGUI EnemyZone2AbilityusedText;


    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonob.GetComponent<EndTurnButton>();

        if (E.EnemyAbilityUsedZone2 == false)
        {
            E.EnemyAbilityUsedZone2 = true;
            EnemyZone2AbilityusedText.text = "Yes";
        }
        else if (E.EnemyAbilityUsedZone2 == true)
        {
            E.EnemyAbilityUsedZone2 = false;
            EnemyZone2AbilityusedText.text = "No";
        }

    }
}
