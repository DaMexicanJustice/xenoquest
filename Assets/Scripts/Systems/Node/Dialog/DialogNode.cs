﻿using System;
using NodeEditorFramework;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using NodeEditorFramework.Utilities;

/// <summary>
/// This node has one entry and one exit, it is just to display something, then move on
/// </summary>
[Node(false, "Node/Dialog Node")]
public class DialogNode : BaseDialogNode
{
	public override string Title {get { return "Dialog Node"; } }
	public override Vector2 MinSize { get { return new Vector2(350, 60); } }
	public override bool AutoLayout { get { return true; } }

	private const string Id = "dialogNode";
	public override string GetID { get { return Id; } }
	public override Type GetObjectType { get { return typeof(DialogNode); } }

	//Previous Node Connections
	[ValueConnectionKnob("From Previous", Direction.In, "NodeForward", NodeSide.Left, 30)]
	public ValueConnectionKnob fromPreviousIN;
	[ConnectionKnob("To Previous", Direction.Out, "NodeBack", NodeSide.Left, 50)]
	public ConnectionKnob toPreviousOut;

	//Next Node to go to
	[ValueConnectionKnob("To Next", Direction.Out, "NodeForward", NodeSide.Right, 30)]
	public ValueConnectionKnob toNextOUT;
	[ConnectionKnob("From Next",Direction.In, "NodeBack", NodeSide.Right, 50)]
	public ConnectionKnob fromNextIN;

	public NPC npc;
	public Sprite characterPortrait;
	public Sprite backgroundImage;
	public string dialogLine;

	public AudioClip soundDialog;

	Vector2 scroll;

	protected override void OnCreate ()
	{
		
	}
	#if UNITY_EDITOR
	public override void NodeGUI()
	{
		/*
		fromPreviousIN.DisplayLayout ();
		toPreviousOut.DisplayLayout ();
		toNextOUT.DisplayLayout ();
		fromNextIN.DisplayLayout ();
		characterPortrait = RTEditorGUI.ObjectField ("Character image" , characterPortrait, false);
		backgroundImage = RTEditorGUI.ObjectField ("Background image", backgroundImage, false);
		npc = RTEditorGUI.ObjectField ("Character file", npc, false);

		dialogLine = RTEditorGUI.TextField ("Insert dialog text here", GUILayout.Height(100f));
		soundDialog = RTEditorGUI.ObjectField ("Sound file", soundDialog, false);
		*/


		EditorGUILayout.BeginVertical("Box");
		GUILayout.BeginHorizontal();
		characterPortrait = (Sprite)EditorGUILayout.ObjectField(characterPortrait, typeof(Sprite), false, GUILayout.Width(65f), GUILayout.Height(65f));
		backgroundImage = (Sprite)EditorGUILayout.ObjectField(characterPortrait, typeof(Sprite), false, GUILayout.Width(65f), GUILayout.Height(65f));
		//CharacterName = EditorGUILayout.TextField("", CharacterName);
		npc = (NPC)EditorGUILayout.ObjectField(npc, typeof(NPC), false);
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();

		GUILayout.Space(5);

		GUILayout.BeginHorizontal();

		scroll = EditorGUILayout.BeginScrollView(scroll, GUILayout.Height(100));
		EditorStyles.textField.wordWrap = true;
		dialogLine = EditorGUILayout.TextArea(dialogLine, GUILayout.ExpandHeight(true));
		EditorStyles.textField.wordWrap = false;
		EditorGUILayout.EndScrollView();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		EditorGUIUtility.labelWidth = 90;
		soundDialog = EditorGUILayout.ObjectField("Dialog Audio:", soundDialog, typeof(AudioClip), false) as AudioClip;
		if (GUILayout.Button("►", GUILayout.Width(20)))
		{
			if (soundDialog) {
				//AudioUtils.PlayClip(SoundDialog);
			}
		}
		GUILayout.EndHorizontal();

	}
	#endif

	public override BaseDialogNode Input(int inputValue)
	{
		/*
		switch (inputValue)
		{

		case (int)EDialogInputValue.Next:
			if (IsNextAvailable ())
				return getTargetNode (toNextOUT);
			break;
		case (int)EDialogInputValue.Back:
			if (IsBackAvailable ())
				return getTargetNode (fromPreviousIN);
			break;

		}*/

		return null;
	}

	public override bool IsBackAvailable()
	{
		return IsAvailable (toPreviousOut);
	}

	public override bool IsNextAvailable()
	{
		return IsAvailable (toNextOUT);
	}
}