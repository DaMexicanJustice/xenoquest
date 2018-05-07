using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Player Character", menuName = "Xenoquest/Character/Player Character", order=0)]
public class PlayerCharacter : BaseCharacter {

	public BaseStats baseStats;
	public Vitals vitals;
	public Occupation occupation;
	public Creed creed;
	public Fetish fetish;
	public Sexperience sexperience;

}
