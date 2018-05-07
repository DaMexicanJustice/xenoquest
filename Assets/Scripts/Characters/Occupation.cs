using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Occupation", menuName = "Xenoquest/Character/Occupation", order=3)]
public class Occupation : ScriptableObject {
	public string occupationName;
	public int endurance;
	public int strength;
	public int allure;
	public int willpower;
	public int persuasion;
	public int swiftness;
}