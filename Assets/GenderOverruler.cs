using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenderOverruler : MonoBehaviour {

    public Dropdown genderDropdown;
    public Text dialogueBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (genderDropdown.options[genderDropdown.value] != genderDropdown.options[0]) {
            genderDropdown.value = 0;
            dialogueBox.gameObject.SetActive(true);
        }
	}
}
