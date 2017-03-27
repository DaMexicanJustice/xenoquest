using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNav : MonoBehaviour {

    public void QuitGame() {
        Application.Quit();
    }

    public void StartGame() {
        Debug.Log("Starting Game!");
    }

    public void ConfirmCharacter() {
        Debug.Log("Confirming character! Game starts...");
    }

    public void LoadGame() {
        Debug.Log("This is where I would load the game if you could");
    }

    public void ViewXenodex() {
        Debug.Log("Viewing porn. Kidding! Not implmented yet ;D ;D ;D ;D");
    }
}
