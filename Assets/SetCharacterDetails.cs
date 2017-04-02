using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCharacterDetails : MonoBehaviour {

    public PlayerCharacter pc;
    public InputField nameInput;
    public Slider ageInput;
    public Dropdown occupationInput;
    public Dropdown creedInput;
    public Dropdown fetishInput;

    public void SetCharacterName() {
        string name = nameInput.text;
        pc.SetName(name);
        Debug.Log(name);
    }

    public void SetCharacterAge()
    {
        int age = (int) ageInput.value;
        pc.SetAge(age);
        Debug.Log(age);
    }

    public void SetCharacterOccupation()
    {
        string foccupation = occupationInput.options[occupationInput.value].text;
        pc.SetOccupation(foccupation);
        Debug.Log(foccupation);
    }

    public void SetCharacterCreed()
    {
        string creed = creedInput.options[creedInput.value].text;
        pc.SetCreed(creed);
        Debug.Log(creed);
    }

    public void SetCharacterFetish()
    {
        string fetish = fetishInput.options[fetishInput.value].text;
        pc.SetFetish(fetish);
        Debug.Log(fetish);
    }
}
