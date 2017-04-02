using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    private string playerName;
    private int age;
    private string gender;
    private string former_occupation;
    private string creed;
    private string fetish;

    public void Update() {
  
    }

    public void SetName(string n) {
        playerName = n;
    }

    public string GetName() {
        return playerName;
    }

    public void SetAge(int a) {
        age = a;
    }

    public int GetAge() {
        return age;
    }

    public void SetGender(string g) {
        gender = g;
    }

    public string GetGender() {
        return gender;
    }

    public void SetOccupation(string fo) {
        former_occupation = fo;
    }

    public string GetOccupation() {
        return former_occupation;
    }

    public void SetCreed(string c) {
        creed = c;
    }

    public string GetCreed() {
        return creed;
    }

    public void SetFetish(string f) {
        fetish = f;
    }

    public string GetFetish() {
        return fetish;
    }
}
