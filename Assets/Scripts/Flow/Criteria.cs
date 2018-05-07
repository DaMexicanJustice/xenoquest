using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName="New Criteria", menuName = "Xenoquest/Flow/Criteria", order=0)]
public class Criteria : ScriptableObject {

	public string criteriaName;
	public CriteriaOptions requirement;
	public string statSelected;
	public int alignmentRequired;
	public int enduranceRequired;
	public int strengthRequired;
	public int allureRequired;
	public int willpowerRequired;
	public int persuasionRequired;
	public int swiftnessRequired;
	public BaseItem itemRequired;
	public BaseQuest questRequired;

}