using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyAbilityZ1Toggle : MonoBehaviour
{
    public GameObject EndTurnButtonob;
    public TextMeshProUGUI EnemyZone1AbilityusedText;

    
    public void PressingAbilityButton()
    {
        EndTurnButton E = EndTurnButtonob.GetComponent<EndTurnButton>();

        if (E.EnemyAbilityUsedZone1 == false)
        {
            E.EnemyAbilityUsedZone1 = true;
            EnemyZone1AbilityusedText.text = "Yes";
        }
        else if (E.EnemyAbilityUsedZone1 == true)
        {
            E.EnemyAbilityUsedZone1 = false;
            EnemyZone1AbilityusedText.text = "No";
        }

    }
}
