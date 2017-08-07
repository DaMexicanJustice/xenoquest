using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Base Item", menuName = "Xenoquest/Items/BaseItem", order=0)]
public class BaseItem : ScriptableObject {

	public string name;
	public string description;
	public Sprite icon;

}
