using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Location", menuName = "Xenoquest/World/Location", order=1)]
public class Location : ScriptableObject {

	public string nameOfLocation;
	public List<Area> areas;
	public List<Sprite> backgroundImages;
	public AudioClip music;


}
