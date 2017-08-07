using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Main World", menuName = "Xenoquest/World/MainWorld", order=2)]
public class World : ScriptableObject {

	public string nameOfWorld;
	public AudioClip music;
	public List<Location> locations;
}
