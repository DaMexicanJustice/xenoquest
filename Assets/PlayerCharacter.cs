using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{

    // Basic
    string playerName;
    int age;
    string gender;
    string former_occupation;
    string creed;
    string fetish;

    // Action Stats
    int str;
    int wp;
    int per;
    int end;
    int all;
    int swf;
    int maxHP;
    int curHP;
    int maxWill;
    int curWill;

    // Personality Stats
    int alignmentPoints;
    public enum Alignment { Wicked, Douchebag, Neutral, Honorable, Righteous };
    public Alignment alignment = Alignment.Neutral;
    int sexperience;

    public void SetAlignmentPoints(int val)
    {
        alignmentPoints = val;
        UpdateAlignment();
    }

    public void IncreaseAlignment(int val)
    {
        alignmentPoints += val;
        UpdateAlignment();
    }

    public void DecreaseAlignment(int val)
    {
        alignmentPoints -= val;
        UpdateAlignment();
    }

    public int GetAlignmentPoints()
    {
        return alignmentPoints;
    }

    void UpdateAlignment()
    {
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
        else if (alignmentPoints >= 90)
        {
            alignment = Alignment.Righteous;
        }
    }

    void CheckProfile(string occupation)
    {
        switch (occupation)
        {
            case "Mercenary":
                str = 60;
                end = 50;
                all = 20;
                wp = 20;
                per = 10;
                swf = 30;
                break;
            case "Blacksmith":
                str = 50;
                end = 60;
                all = 20;
                wp = 30;
                per = 30;
                swf = 10;
                break;
            case "Spy":
                str = 10;
                end = 40;
                all = 40;
                wp = 40;
                per = 40;
                swf = 40;
                break;
            case "Gigolo":
                str = 20;
                end = 30;
                all = 20;
                wp = 40;
                per = 40;
                swf = 50;
                break;
            case "Vagabond":
                str = 60;
                end = 50;
                all = 20;
                wp = 20;
                per = 10;
                swf = 30;
                break;
            case "Diplomat":
                str = 10;
                end = 30;
                all = 40;
                wp = 50;
                per = 60;
                swf = 10;
                break;
            case "Hunter":
                str = 20;
                end = 40;
                all = 30;
                wp = 40;
                per = 10;
                swf = 60;
                break;
            case "Squire":
                str = 60;
                end = 50;
                all = 20;
                wp = 20;
                per = 10;
                swf = 30;
                break;
            case "Missionary":
                str = 30;
                end = 10;
                all = 20;
                wp = 60;
                per = 60;
                swf = 20;
                break;
            case "Merchant":
                str = 10;
                end = 30;
                all = 40;
                wp = 40;
                per = 60;
                swf = 30;
                break;
        }
    }

    public void SetName(string n)
    {
        playerName = n;
    }

    public string GetName()
    {
        return playerName;
    }

    public void SetAge(int a)
    {
        age = a;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGender(string g)
    {
        gender = g;
    }

    public string GetGender()
    {
        return gender;
    }

    public void SetOccupation(string fo)
    {
        former_occupation = fo;
        CheckProfile(former_occupation);
    }

    public string GetOccupation()
    {
        return former_occupation;
    }

    public void SetCreed(string c)
    {
        creed = c;
        CheckCreed(creed);
    }

    void CheckCreed(string c)
    {
        switch (c)
        {
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

    public string GetCreed()
    {
        return creed;
    }

    public void SetFetish(string f)
    {
        fetish = f;
    }

    public string GetFetish()
    {
        return fetish;
    }

    public int GetStr()
    {
        return str;
    }

    public int GetEnd()
    {
        return end;
    }

    public int GetPer()
    {
        return per;
    }

    public int GetAll()
    {
        return all;
    }

    public int GetSwf()
    {
        return swf;
    }

    public int GetWP()
    {
        return wp;
    }
}
