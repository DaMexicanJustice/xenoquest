using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Accessory", menuName = "Xenoquest/Items/Accessory", order=1)]
public class Accessory : BaseItem {

	public enum Perk {
		//TentacleTickler
		StrPlus, EndPlus, PerPlus, SwfPlus, AllPlus, WilPlus,
		SharpEarSuave, FutaBait, AmazonConnoisseur, FurFucker,
	}

	public Perk perk;
}
