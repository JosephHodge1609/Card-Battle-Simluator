using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTurnButton : MonoBehaviour
{

    public bool AbilityUsedZone1 = false;
    public bool AbilityUsedZone2 = false;
    public bool AbilityUsedZone3 = false;
    public bool EnemyAbilityUsedZone1 = false;
    public bool EnemyAbilityUsedZone2 = false;
    public bool EnemyAbilityUsedZone3 = false;


    //hero battlezone 1
    public TextMeshProUGUI Zone1HeroHealth;
    public TextMeshProUGUI Zone1EffectCounter;
    public TextMeshProUGUI Zone1StatCounter;
    public TextMeshProUGUI Zone1Stamina;
    public TextMeshProUGUI Zone1AbilityToggle;
    //hero battlezone 2
    public TextMeshProUGUI Zone2HeroHealth;
    public TextMeshProUGUI Zone2EffectCounter;
    public TextMeshProUGUI Zone2StatCounter;
    public TextMeshProUGUI Zone2Stamina;
    public TextMeshProUGUI Zone2AbilityToggle;
    //hero battlezone 3
    public TextMeshProUGUI Zone3HeroHealth;
    public TextMeshProUGUI Zone3EffectCounter;
    public TextMeshProUGUI Zone3StatCounter;
    public TextMeshProUGUI Zone3Stamina;
    public TextMeshProUGUI Zone3AbilityToggle;
    //enemy battlezone1
    public TextMeshProUGUI EnemyZone1AbilityToggle;
    public TextMeshProUGUI EnemyZone1HeroHealth;
    public TextMeshProUGUI EnemyZone1EffectCounter;
    public TextMeshProUGUI EnemyZone1StatCounter;
    public TextMeshProUGUI EnemyZone1Stamina;
    //enemy battlezone2
    public TextMeshProUGUI EnemyZone2AbilityToggle;
    public TextMeshProUGUI EnemyZone2HeroHealth;
    public TextMeshProUGUI EnemyZone2EffectCounter;
    public TextMeshProUGUI EnemyZone2StatCounter;
    public TextMeshProUGUI EnemyZone2Stamina;
    //enemy battlezone3
    public TextMeshProUGUI EnemyZone3AbilityToggle;
    public TextMeshProUGUI EnemyZone3HeroHealth;
    public TextMeshProUGUI EnemyZone3EffectCounter;
    public TextMeshProUGUI EnemyZone3StatCounter;
    public TextMeshProUGUI EnemyZone3Stamina;


    public void EndingTurn()
    {   //hero battlezone 1
        int HeroHPZone1 = int.Parse(Zone1HeroHealth.text);
        int ZoneOneEffectCounter = int.Parse(Zone1EffectCounter.text);
        int ZoneOneStatCounter = int.Parse(Zone1StatCounter.text);
        int ZoneOneStamina = int.Parse(Zone1Stamina.text);
        //hero battlezone 2
        int HeroHPZone2 = int.Parse(Zone2HeroHealth.text);
        int ZoneTwoEffectCounter = int.Parse(Zone2EffectCounter.text);
        int ZoneTwoStatCounter = int.Parse(Zone2StatCounter.text);
        int ZoneTwoStamina = int.Parse(Zone2Stamina.text);
        //hero battlezone 3
        int HeroHPZone3 = int.Parse(Zone3HeroHealth.text);
        int ZoneThreeEffectCounter = int.Parse(Zone3EffectCounter.text);
        int ZoneThreeStatCounter = int.Parse(Zone3StatCounter.text);
        int ZoneThreeStamina = int.Parse(Zone3Stamina.text);
        //enemy battlezone 1
        int EnemyHPZone1 = int.Parse(EnemyZone1HeroHealth.text);
        int EnemyZoneOneEffectCounter = int.Parse(EnemyZone1EffectCounter.text);
        int EnemyZoneOneStatCounter = int.Parse(EnemyZone1StatCounter.text);
        int EnemyZoneOneStamina = int.Parse(EnemyZone1Stamina.text);
        //enemy battlezone 2
        int EnemyHPZone2 = int.Parse(EnemyZone2HeroHealth.text);
        int EnemyZoneTwoEffectCounter = int.Parse(EnemyZone2EffectCounter.text);
        int EnemyZoneTwoStatCounter = int.Parse(EnemyZone2StatCounter.text);
        int EnemyZoneTwoStamina = int.Parse(EnemyZone2Stamina.text);
        //enemy battlezone 3
        int EnemyHPZone3 = int.Parse(EnemyZone3HeroHealth.text);
        int EnemyZoneThreeEffectCounter = int.Parse(EnemyZone3EffectCounter.text);
        int EnemyZoneThreeStatCounter = int.Parse(EnemyZone3StatCounter.text);
        int EnemyZoneThreeStamina = int.Parse(EnemyZone3Stamina.text);


        //Hero Side zone 1 checking

        if (AbilityUsedZone1 == false)
            {
                ZoneOneStamina += 1;
           
            }
            if (AbilityUsedZone1 == true)
            {
                AbilityUsedZone1 = false;
                Zone1AbilityToggle.text = "No";
            }
            if (ZoneOneEffectCounter >= 1)
            {
                ZoneOneEffectCounter -= 1;
                HeroHPZone1 -= 1;
            }
            if (ZoneOneStatCounter >= 1)
            {
                ZoneOneStatCounter -= 1;
            }
            Zone1HeroHealth.text = HeroHPZone1.ToString();
            Zone1EffectCounter.text = ZoneOneEffectCounter.ToString();
            Zone1Stamina.text = ZoneOneStamina.ToString();
            Zone1StatCounter.text = ZoneOneStatCounter.ToString();

        //Hero Side zone 2 checking

        if (AbilityUsedZone2 == false)
        {
            ZoneTwoStamina += 1;
            
        }
        if (AbilityUsedZone2 == true)
        {
            AbilityUsedZone2 = false;
            Zone2AbilityToggle.text = "No";
        }
        if (ZoneTwoEffectCounter >= 1)
        {
            ZoneTwoEffectCounter -= 1;
            HeroHPZone2 -= 1;
        }
        if (ZoneTwoStatCounter >= 1)
        {
            ZoneTwoStatCounter -= 1;
        }
        Zone2HeroHealth.text = HeroHPZone2.ToString();
        Zone2EffectCounter.text = ZoneTwoEffectCounter.ToString();
        Zone2Stamina.text = ZoneTwoStamina.ToString();
        Zone2StatCounter.text = ZoneTwoStatCounter.ToString();

        //Hero Side zone 3 checking

        if (AbilityUsedZone3 == false)
        {
            ZoneThreeStamina += 1;

        }
        if (AbilityUsedZone3 == true)
        {
            AbilityUsedZone3 = false;
            Zone3AbilityToggle.text = "No";
        }
        if (ZoneThreeEffectCounter >= 1)
        {
            ZoneThreeEffectCounter -= 1;
            HeroHPZone3 -= 1;
        }
        if (ZoneThreeStatCounter >= 1)
        {
            ZoneThreeStatCounter -= 1;
        }
        Zone3HeroHealth.text = HeroHPZone3.ToString();
        Zone3EffectCounter.text = ZoneThreeEffectCounter.ToString();
        Zone3Stamina.text = ZoneThreeStamina.ToString();
        Zone3StatCounter.text = ZoneThreeStatCounter.ToString();

        //Enemy Side Zone 1 Checking
        if (EnemyAbilityUsedZone1 == false)
        {
            EnemyZoneOneStamina += 1;
        }
        if (EnemyAbilityUsedZone1 == true)
        {
            EnemyAbilityUsedZone1 = false;
            EnemyZone1AbilityToggle.text = "No";
        }
        if (EnemyZoneOneEffectCounter >= 1)
        {
            EnemyZoneOneEffectCounter -= 1;
            EnemyHPZone1 -= 1;
        }
        if (EnemyZoneOneStatCounter >= 1)
        {
            EnemyZoneOneStatCounter -= 1;
        }
        EnemyZone1HeroHealth.text = EnemyHPZone1.ToString();
        EnemyZone1EffectCounter.text = EnemyZoneOneEffectCounter.ToString();
        EnemyZone1Stamina.text = EnemyZoneOneStamina.ToString();
        EnemyZone1StatCounter.text = EnemyZoneOneStatCounter.ToString();

        //Enemy Side Zone 2 Checking
        if (EnemyAbilityUsedZone2 == false)
        {
            EnemyZoneTwoStamina += 1;
        }
        if (EnemyAbilityUsedZone2 == true)
        {
            EnemyAbilityUsedZone2 = false;
            EnemyZone2AbilityToggle.text = "No";
        }
        if (EnemyZoneTwoEffectCounter >= 1)
        {
            EnemyZoneTwoEffectCounter -= 1;
            EnemyHPZone2 -= 1;
        }
        if (EnemyZoneTwoStatCounter >= 1)
        {
            EnemyZoneTwoStatCounter -= 1;
        }
        EnemyZone2HeroHealth.text = EnemyHPZone2.ToString();
        EnemyZone2EffectCounter.text = EnemyZoneTwoEffectCounter.ToString();
        EnemyZone2Stamina.text = EnemyZoneTwoStamina.ToString();
        EnemyZone2StatCounter.text = EnemyZoneTwoStatCounter.ToString();

        //Enemy Side Zone 3 Checking
        if (EnemyAbilityUsedZone3 == false)
        {
            EnemyZoneThreeStamina += 1;
        }
        if (EnemyAbilityUsedZone3 == true)
        {
            EnemyAbilityUsedZone3 = false;
            EnemyZone3AbilityToggle.text = "No";
        }
        if (EnemyZoneThreeEffectCounter >= 1)
        {
            EnemyZoneThreeEffectCounter -= 1;
            EnemyHPZone3 -= 1;
        }
        if (EnemyZoneThreeStatCounter >= 1)
        {
            EnemyZoneThreeStatCounter -= 1;
        }
        EnemyZone3HeroHealth.text = EnemyHPZone3.ToString();
        EnemyZone3EffectCounter.text = EnemyZoneThreeEffectCounter.ToString();
        EnemyZone3Stamina.text = EnemyZoneThreeStamina.ToString();
        EnemyZone3StatCounter.text = EnemyZoneThreeStatCounter.ToString();
    }
}
