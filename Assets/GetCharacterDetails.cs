using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCharacterDetails : MonoBehaviour {

    public PlayerCharacter pc;
    public Text details;

    public void Start() {
        
    }

    public void UpdateText() {
        Debug.Log(pc.GetFetish());
        details.text = " Name: " +  pc.GetName() + "\n Age: " + pc.GetAge() + "\n Gender: " + pc.GetGender() + 
            "\n Former Occupation: " + pc.GetOccupation() + "\n Creed: \n " + pc.GetCreed() + "\n Fetish: " + pc.GetFetish();
    }


}

