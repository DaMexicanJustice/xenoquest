using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCharacterDetails : MonoBehaviour
{

    public PlayerCharacter pc;
    public Text details;

    public void Start()
    {

    }


    public void UpdateText()
    {
        Debug.Log("Calling method");
        details.text = 
            "\n \n Name: " + pc.GetName() + "\n \n Age: " + pc.GetAge() + "\n \n Gender: " + pc.GetGender() +
            "\n \n Former Occupation: " + pc.GetOccupation() + "\n \n Creed: \n \n " + pc.GetCreed() + "\n \n Fetish: " + pc.GetFetish() +
            "\n \n Alignment: " + pc.alignment +
            "\n \n Action Stats [10 : 100]: " +
            "\n  STRENGTH: " + pc.GetStr() +
            "\n  ENDURANCE: " + pc.GetEnd() +
            "\n  PERSUASION: " + pc.GetPer() +
            "\n  ALLURE: " + pc.GetAll() +
            "\n  SWIFTNESS: " + pc.GetSwf() +
            "\n  WILLPOWER: " + pc.GetWP();

    }
}

