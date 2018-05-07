using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Criteria))]
public class CriteriaEditor : Editor {

	CriteriaOptions criteriaSelected;
	//string[] statOptions = { "Endurance", "Strength", "Allure", "Willpower", "Persuasion", "Swiftness" };
	public enum statOptions {
		ENDURACE, STRENGTH, ALLURE, WILLPOWER, PERSUASION, SWIFTNESS
	}
	public statOptions statSelected;

	public BaseItem itemSelected;
	public BaseQuest questSelected;

	public override void OnInspectorGUI() {
		Criteria myTarget = target as Criteria;

		myTarget.criteriaName = EditorGUILayout.TextField ("Criteria Name", myTarget.criteriaName);
		criteriaSelected = (CriteriaOptions)EditorGUILayout.EnumPopup (criteriaSelected);

		switch (criteriaSelected) {
		case CriteriaOptions.ALIGNMENTREQUIRED:
			myTarget.alignmentRequired = EditorGUILayout.IntField ("Alignment required", myTarget.alignmentRequired);
			break;
		case CriteriaOptions.ITEMINPOSSESSION:
			myTarget.itemRequired = EditorGUILayout.ObjectField ("Item needed", itemSelected, typeof(BaseItem), false) as BaseItem; 
			break;
		case CriteriaOptions.QUESTCOMPLETED:
			myTarget.questRequired = EditorGUILayout.ObjectField ("Item needed", itemSelected, typeof(BaseItem), false) as BaseQuest; 
			break;
		case CriteriaOptions.STATREQUIRED:
			statSelected = (statOptions)EditorGUILayout.EnumPopup (statSelected);
			switch (statSelected) {
			case statOptions.ENDURACE:
				myTarget.enduranceRequired = EditorGUILayout.IntField ("Endurance required", myTarget.enduranceRequired);
				break;
			case statOptions.STRENGTH:
				myTarget.strengthRequired = EditorGUILayout.IntField ("Strength required", myTarget.strengthRequired);
				break;
			case statOptions.ALLURE:
				myTarget.allureRequired = EditorGUILayout.IntField ("Allure required", myTarget.allureRequired);
				break;
			case statOptions.WILLPOWER:
				myTarget.willpowerRequired = EditorGUILayout.IntField ("Willpower required", myTarget.willpowerRequired);
				break;
			case statOptions.PERSUASION:
				myTarget.persuasionRequired = EditorGUILayout.IntField ("Persuasion required", myTarget.persuasionRequired);
				break;
			case statOptions.SWIFTNESS:
				myTarget.swiftnessRequired = EditorGUILayout.IntField ("Swiftness required", myTarget.swiftnessRequired);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}
		PromptSummary (myTarget);
	}

	void PromptSummary(Criteria c) {
		EditorGUILayout.LabelField ("");
		EditorGUILayout.LabelField ("Summary");
		EditorGUILayout.LabelField ("-----------------");

		EditorGUILayout.LabelField ("Alignment required:" + c.alignmentRequired);

		EditorGUILayout.LabelField ("End:" + c.enduranceRequired + "| Str:" + c.strengthRequired + "| All:" + c.allureRequired
			+ "| Wil:" + c.willpowerRequired + "| Per:" + c.persuasionRequired + "| Swi:" + c.swiftnessRequired);

		EditorGUILayout.LabelField ("Item needed" + c.itemRequired);

		EditorGUILayout.LabelField ("Quest completed" + c.questRequired);
	}

}
