using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCharacterDetails : MonoBehaviour {

    public PlayerCharacter pc;
    private Text displayText;

    public void Start() {
        displayText = GetComponent<Text>();
    }

    public void UpdateText() {
        displayText.text += pc.GetName();
        displayText.text += "" + pc.GetAge();
        displayText.text += pc.GetGender();
        displayText.text += pc.GetOccupation();
        displayText.text += pc.GetCreed();
        displayText.text += pc.GetFetish();
    }
}

