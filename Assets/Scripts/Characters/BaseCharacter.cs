using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Minor Character", menuName = "Xenoquest/Characters/MinorCharacter", order=3)]
public class BaseCharacter : ScriptableObject {

	public List<Conversation> conversations;
	public string characterName;
	public enum Gender {
		male, female, intersex
	}
	[Tooltip("Male, female or character who is not quite male and not quite female")]
	public Gender gender;
	[Range(1,99)]
	public int age;

}
