using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SuibtractHP : MonoBehaviour
{
    public TextMeshProUGUI Zone1Text;

    public void Subtracting()
    {
        int Health = int.Parse(Zone1Text.text);
        Health -= 1;
        Zone1Text.text = Health.ToString();
    }
}