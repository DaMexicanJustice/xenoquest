using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Area", menuName = "Xenoquest/World/Area", order=0)]
public class Area : ScriptableObject{

	public string nameOfArea;
	public List<BaseCharacter> characters;
	public List<Sprite> backgroundImages;
	public AudioClip music;

}
