using UnityEngine;
using System.Collections;

public class Character {

    // Character bio
    private string name;
    private int age;
    private string gender = "male";

    // Character base stat
    private enum Occupation {
        MERCENARY, BLACKSMITH, HUNTER, MERCHANT,
        GIGOLO, DIPLOMAT, SPY, MISSONARY,
        SQUIRE, VAGABOND
    }
    private Occupation occupation;

    // Character alignment
    private enum Creed {

    }
    // Character weak spot
    private enum Fetish {
    
    }

    // Perks
    private ArrayList perks = new ArrayList();

    // Action stats
    private int endurance;
    private int strength;
    private int allure;
    private int discipline;
    private int charisma;
    private int swiftness;

    // Personality stats
    private int alignmentValue;
    private string alignment;
    private int sexperience;

    // Guages
    private int maxHP;
    private int currentHP;
    private int willpower;
    private int momentum;
    private int ladyKiller;
    private int silverTongue;
    private int overpower;

    

    public bool HasPerk(string name) {
        foreach (string str in perks) {
            if (perks.Equals(name)) {
                return true;
            }
        }
        return false;
    }

    public ArrayList GetPerks() {
        return perks;
    }

    public void AddPerk(string perkName) {
        perks.Add(perkName);
    }

    public void RemovePerk(string perkName) {
        perks.Remove(perkName);
    }

    public string GetName() {
        return name;
    }

    public void SetName(string name) {
        this.name = name;
    }

    public int GetAge() {
        return age;
    }

    public void SetAge(int age) {
        this.age = age;
    }

    public string GetGender() {
        return gender;
    }

    public void SetOccupation(string occ) {
        string o = occ.ToUpper();
        switch (o) {
            case "MERCENARY":
                occupation = Occupation.MERCENARY;
                break;
            case "BLACKSMITH":
                occupation = Occupation.BLACKSMITH;
                break;
            case "HUNTER":
                occupation = Occupation.HUNTER;
                break;
            case "MERCHANT":
                occupation = Occupation.MERCHANT;
                break;
            case "GIGOLO":
                occupation = Occupation.GIGOLO;
                break;
            case "DIPLOMAT":
                occupation = Occupation.DIPLOMAT;
                break;
            case "SPY":
                occupation = Occupation.SPY;
                break;
            case "MISSIONARY":
                occupation = Occupation.MISSONARY;
                break;
            case "SQUIRE":
                occupation = Occupation.SQUIRE;
                break;
            case "VAGABOND":
                occupation = Occupation.VAGABOND;
                break;
            default:
                occupation = Occupation.VAGABOND;
                break;
        }
    }

    public string GetOccupation() {
        return occupation.ToString();
    }

    public void AddAlignment(int value) {
        alignmentValue += value;
    }

    public void SubtractAlignment(int value) {
        alignmentValue -= value;
    }

    public string CheckAndReturnAlignment() {
        if (10 >= alignmentValue)
        {
            alignment = "villain";
        }
        else if (40 >= alignmentValue)
        {
            alignment = "douchebag";
        }
        else if (50 >= alignmentValue)
        {
            alignment = "neutral";
        }
        else if (60 >= alignmentValue)
        {
            alignment = "honorable";
        }
        else if (90 >= alignmentValue) {
            alignment = "righteous";
        }
        return alignment;
    }

    public void SetEndurance(int endurance) {
        this.endurance = endurance;
    }

    public void SetStrength (int strength)
    {
        this.strength = strength;
    }

    public void SetDiscipline(int discipline)
    {
        this.discipline = discipline;
    }

    public void setSwiftness(int swiftness)
    {
        this.swiftness = swiftness;
    }

    public void setAllure(int allure)
    {
        this.allure = allure;
    }

    public void setCharisma(int charisma)
    {
        this.charisma = charisma;
    }

    public int getEndurance() {
        return endurance;
    }

    public int getStrength()
    {
        return strength;
    }

    public int getDiscipline()
    {
        return discipline;
    }

    public int getSwiftness()
    {
        return swiftness;
    }

    public int getAllure()
    {
        return allure;
    }

    public int getCharisma()
    {
        return charisma;
    }

    public int getSexperience() {
        return sexperience;
    }

    public void addSexperience(int value) {
        sexperience += value;
    }

    public void AddToOverpower(int value) {
        overpower += value;
    }

    public void ResetOverpower() {
        overpower = 0;
    }

    public int getOverpower() {
        return overpower;
    }

    public void AddToMomentum(int value)
    {
        momentum += value;
    }

    public void ResetMomentum()
    {
        momentum = 0;
    }

    public int getMomentum()
    {
        return momentum;
    }

    public void AddToSilverTongue(int value)
    {
        silverTongue += value;
    }

    public void ResetSilverTongue()
    {
        silverTongue = 0;
    }

    public int getSilverTongue()
    {
        return silverTongue;
    }

    public void AddToLadyKiller(int value)
    {
        ladyKiller += value;
    }

    public void ResetLadyKiller()
    {
        ladyKiller = 0;
    }

    public int getLadyKiller()
    {
        return ladyKiller;
    }

    public void TakeDamage(int dmg) {
        currentHP -= dmg;
    }

    public void Heal(int value) {
        currentHP += value;
    }

    public bool IsDead() {
        if (currentHP <= 0) {
            return true;
        }
        return false;
    }

    public void ResetHP() {
        currentHP = maxHP;
    }

    public void AddToMax(int value) {
        maxHP += value;
    }

}
