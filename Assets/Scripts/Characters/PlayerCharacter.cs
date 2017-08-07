using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	public int maxHP;
	private int lifeGauge;
	public int maxWP;
	private int willGauge;
	public int maxLust;
	private int seductionGauge;

	public int str;
	public int end;
	public int all;
	public int wil;
	public int swi;
	public int per;

	public PlayerCharacter() {
		lifeGauge = maxHP;
		willGauge = maxWP;
		seductionGauge = maxLust;
	}

	public string characterName;
	public enum Gender {
		male, female, intersex
	}
	[Tooltip("Male, female or character who is not quite male and not quite female")]
	public Gender gender;
	[Range(1,99)]
	public int age;

	public enum Occupation {
		Mercenary, Blacksmith, Hunter, Merchant,
		Gigolo, Diplomat, Spy, Missionary,
		Squire, Vagabond
	}

	public Occupation occupation;

	public enum Fetish
	{
		Ageplay, Incest, Skincolor, Submissive, 
		Intersex, Unattainable
	}

	public Fetish fetish;

	public enum Creed
	{
		Villain1, Villain2, Douchebag1, Douchebag2,
		Neutral,
		Honorable1, Honorable2, Righteous1, Righteous2
	}

	public Creed creed;

	[Range(0,100)]
	public int alignment;

	[Range(0,10000)]
	public int sexperience;

}
