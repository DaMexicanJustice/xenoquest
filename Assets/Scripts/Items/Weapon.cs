using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Weapon", menuName = "Xenoquest/Items/Weapon", order=2)]
public class Weapon : BaseItem {

	public enum Power {
		None, Swift, Powerful, 
	}

	public Power power;

	public enum Perk {
		None, MonsterSlayer, BeastKiller, UndeadVanquisher, WhimsyStopper, ManEater, RobotTerminator
	}

	public Perk perk;

}
