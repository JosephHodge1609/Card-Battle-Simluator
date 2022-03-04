using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddHPZ1 : MonoBehaviour
{
    
    public TextMeshProUGUI Zone1Text;

    public void Adding()
    {
        int Health = int.Parse(Zone1Text.text);
        Health += 1;
        Zone1Text.text = Health.ToString();
    }
}
