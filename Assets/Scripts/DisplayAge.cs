using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAge : MonoBehaviour {

    public Slider mySlider;
    private Text ageText;

    // Use this for initialization
    void Start () {
        ageText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ageText.text = "" + mySlider.value;
	}
}
