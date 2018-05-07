using System;
using NodeEditorFramework;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using NodeEditorFramework.Utilities;


/// <summary>
/// This node has one entry and one exit, it is just to display something, then move on
/// </summary>
[Node(false, "Node/Criteria Node")]
public class CriteriaNode : BaseDialogNode
{
	public override string Title {get { return "Criteria Node"; } }
	public override Vector2 MinSize { get { return new Vector2(350, 60); } }
	public override bool AutoLayout { get { return true; } }

	private const string Id = "criteriaNode";
	public override string GetID { get { return Id; } }
	public override Type GetObjectType { get { return typeof(CombatNode); } }

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

	private Vector2 scroll;

	public Criteria criteria;

	public AudioClip SoundDialog;

	protected override void OnCreate ()
	{

	}
	#if UNITY_EDITOR
	public override void NodeGUI()
	{
		EditorGUILayout.BeginVertical("Box");
		GUILayout.BeginHorizontal();
		criteria = (Criteria)EditorGUILayout.ObjectField(criteria, typeof(Criteria), false);
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();

		GUILayout.Space(5);
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

		}
		*/
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