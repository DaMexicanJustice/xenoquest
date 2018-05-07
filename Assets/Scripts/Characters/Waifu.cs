using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Waifu", menuName = "Xenoquest/Character/Waifu", order=6)]
public class Waifu : NPC {

	public Trait trait;
	public BaseStats baseStats;
	public Vitals vitals;
	public RelationStat relationStat;
}
