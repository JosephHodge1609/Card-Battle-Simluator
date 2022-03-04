using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCards : MonoBehaviour
{


    public GameObject Hand;
    public GameObject LoneArcher;
    public GameObject LonePaladin;
    public GameObject LoneCleric;
    public GameObject LoneMage;
    public GameObject LoneKnight;
    public GameObject PyroSentinel;
    public GameObject FlameHuntress;
    public GameObject EmblemWizard;
    public GameObject EmberSoldier;
    public GameObject Doranyx;
    public GameObject CrimsonAssassin;
    public GameObject Cecillia;
    public GameObject Ashir;
    public GameObject DreadMermaid;


    public void HandleInputData(int Choice)
    {
        switch (Choice)
        {
            case 1: Instantiate(LoneArcher, transform.position, Quaternion.identity, Hand.transform);       
                break;
            case 2:
                Instantiate(LonePaladin, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 3:
                Instantiate(LoneCleric, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 4:
                Instantiate(LoneMage, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 5:
                Instantiate(LoneKnight, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 6:
                Instantiate(PyroSentinel, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 7:
                Instantiate(FlameHuntress, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 8:
                Instantiate(EmblemWizard, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 9:
                Instantiate(EmberSoldier, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 10:
                Instantiate(Doranyx, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 11:
                Instantiate(CrimsonAssassin, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 12:
                Instantiate(Cecillia, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 13:
                Instantiate(Ashir, transform.position, Quaternion.identity, Hand.transform);
                break;
            case 14:
                Instantiate(DreadMermaid, transform.position, Quaternion.identity, Hand.transform); 
                break;
        }
    }
}
