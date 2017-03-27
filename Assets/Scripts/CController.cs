using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CController : MonoBehaviour {

    private Character character = new Character();
    public InputField nameField;
    public Button nNext;

    // Use this for initialization
    private void Start()
    {
        InputField.SubmitEvent submitEvent = new InputField.SubmitEvent();
        submitEvent.AddListener(UpdateName);
        nameField.onEndEdit = submitEvent;
    }

    // Update is called once per frame
    void Update () {
	    
	}

    public void UpdateName(string name) {
        character.SetName(name);
            Debug.Log(TestName());
    }

    public string TestName() {
        return character.GetName();
    }

}
