using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Creed", menuName = "Xenoquest/Character/Creed", order=1)]
public class Creed : ScriptableObject {
	public string creed;
	public int alignmentValue;
}