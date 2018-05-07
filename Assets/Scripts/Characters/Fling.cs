using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Fling", menuName = "Xenoquest/Character/Fling", order=5)]
public class Fling : NPC {

	public Trait trait;
	public BaseStats baseStats;
	public Vitals vitals;
	public RelationStat relationStat;
}
