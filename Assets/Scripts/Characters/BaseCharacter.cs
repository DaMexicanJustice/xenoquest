using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : ScriptableObject {

	public string characterName;
	[Range(18,29)]
	public int age;
	public Gender gender;
}
