using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    // Basic
     string playerName;
     int age;
     string gender;
     string former_occupation;
     string creed;
     string fetish;

    // Action Stats
    int strength;
    int willpower;
    int persuasion;
    int endurance;
    int allure;
    int swiftness;
    int maxHP;
    int curHP;
    int maxWill;
    int curWill;

    // Personality Stats
    int alignmentPoints;
    public enum Alignment { Wicked, Douchebag, Neutral, Honorable, Righteous};
    public Alignment alignment = Alignment.Neutral;
    int sexperience;

    public void SetAlignmentPoints(int val) {
        alignmentPoints = val;
        UpdateAlignment();
    }

    public void IncreaseAlignment(int val) {
        alignmentPoints += val;
        UpdateAlignment();
    }

    public void DecreaseAlignment(int val) {
        alignmentPoints -= val;
        UpdateAlignment();
    }

    public int GetAlignmentPoints() {
        return alignmentPoints;
    }

    void UpdateAlignment() {
        if (alignmentPoints <= 10)
        {
            alignment = Alignment.Wicked;
        }
        else if (alignmentPoints <= 40)
        {
            alignment = Alignment.Douchebag;
        }
        else if (alignmentPoints >= 41 && alignmentPoints <= 59)
        {
            alignment = Alignment.Neutral;
        }
        else if (alignmentPoints >= 60)
        {
            alignment = Alignment.Honorable;
        }
        else if (alignmentPoints >= 90) {
            alignment = Alignment.Righteous;
        }
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
        CheckCreed(creed);
    }

    void CheckCreed(string c) {
        switch (c) {
            case "I will have it my way - or it won’t be let to exist at all":
                SetAlignmentPoints(30);
                break;
            case "Some people just want to see the world burn. I’m one of those guys":
                SetAlignmentPoints(30);
                break;
            case "Will it kill me? Can I eat it? Can I fuck it":
                SetAlignmentPoints(40);
                break;
            case "Your problems are just that. Yours":
                SetAlignmentPoints(40);
                break;
            case "Live and let live.":
                SetAlignmentPoints(50);
                break;
            case "I’ll help you. For a price.":
                SetAlignmentPoints(50);
                break;
            case "I always stay true to my word":
                SetAlignmentPoints(60);
                break;
            case "Crime never pays.":
                SetAlignmentPoints(60);
                break;
            case "I don’t need a reason to help people":
                SetAlignmentPoints(70);
                break;
            case "Always be kind if it’s possible. It’s always possible":
                SetAlignmentPoints(70);
                break;
        }
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
