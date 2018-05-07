using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Trait", menuName = "Xenoquest/Character/Trait", order=7)]
public class Trait : ScriptableObject {

	public string typeName;
	public int endurance;
	public int strength;
	public int allure;
	public int willpower;
	public int persuasion;
	public int swiftness;

}
