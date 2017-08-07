using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Fling", menuName = "Xenoquest/Characters/Fling", order=1)]
public class Fling : AdvancedCharacter {

	public List<HScene> hScenes = new List<HScene> ();
	[Range(-50, 50)]
	public int affection;
	public List<Sprite> artwork = new List<Sprite>();


}
