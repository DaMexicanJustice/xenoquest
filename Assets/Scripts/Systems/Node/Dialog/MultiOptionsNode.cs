using System;
using System.Collections.Generic;
using System.Linq;
using NodeEditorFramework;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

/// <summary>
/// One entry and multiple exits, one for each possible answer
/// </summary>
[Node(false, "Node/Dialog With Options Node")]
public class MultiOptionsNode : BaseDialogNode
{
	public override string Title { get { return "Dialog with Options Node"; } }
	public override Vector2 MinSize { get { return new Vector2(400, 60); } }
	public override bool AutoLayout { get { return true; } }

	private const string Id = "multiOptionsNode";
	public override string GetID { get { return Id; } }
	public override Type GetObjectType { get { return typeof(MultiOptionsNode); } }

	//previous node connections
	[ValueConnectionKnob("From Previous", Direction.In, "NodeForward", NodeSide.Left, 30)]
	public ValueConnectionKnob frinPreviousIN;
	[ConnectionKnob("To Previous", Direction.Out, "NodeBack", NodeSide.Left, 50)]
	public ConnectionKnob toPreviousOUT;

	///Next node 
	[ConnectionKnob("From Next",Direction.In, "NodeBack", NodeSide.Right, 50)]
	public ConnectionKnob fromNextIN;

	private const int StartValue = 276;
	private const int SizeValue = 24;

	public AudioClip SoundDialog;

	public NPC npc;
	public Sprite characterPortrait;
	public Sprite backgroundImage;
	public string DialogLine;

	[SerializeField]
	List<DataHolderForOption> _options;
	private Vector2 scroll;

	private ValueConnectionKnobAttribute dynaCreationAttribute 
	= new ValueConnectionKnobAttribute(
		"Next Node", Direction.Out, "NodeForward", NodeSide.Right);

	protected override void OnCreate ()
	{
		DialogLine = "Dialog Line Here";
		characterPortrait = null;

		_options = new List<DataHolderForOption>();

		AddNewOption();
	}
	#if UNITY_EDITOR
	public override void NodeGUI()
	{
		EditorGUILayout.BeginVertical("Box");
		GUILayout.BeginHorizontal();
		characterPortrait = (Sprite)EditorGUILayout.ObjectField(characterPortrait, typeof(Sprite), false, GUILayout.Width(65f), GUILayout.Height(65f));
		backgroundImage = (Sprite)EditorGUILayout.ObjectField(backgroundImage, typeof(Sprite), false, GUILayout.Width(65f), GUILayout.Height(65f));
		npc = (NPC)EditorGUILayout.ObjectField(npc, typeof(NPC), false);
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();

		GUILayout.Space(5);

		EditorStyles.textField.wordWrap = true;

		GUILayout.BeginHorizontal();

		scroll = EditorGUILayout.BeginScrollView(scroll, GUILayout.Height(100));
		DialogLine = EditorGUILayout.TextArea(DialogLine, GUILayout.ExpandHeight(true));
		EditorGUILayout.EndScrollView();
		GUILayout.EndHorizontal();

		GUILayout.Space(5);

		GUILayout.BeginHorizontal();
		EditorGUIUtility.labelWidth = 90;
		SoundDialog = EditorGUILayout.ObjectField("Dialog Audio:", SoundDialog, typeof(AudioClip), false) as AudioClip;
		if (GUILayout.Button("►", GUILayout.Width(20)))
		{
			if (SoundDialog) {
				//AudioUtils.PlayClip(SoundDialog);
			}
		}
		GUILayout.EndHorizontal();

		GUILayout.Space(5);

		#region Options
		GUILayout.BeginVertical("box");
		GUILayout.ExpandWidth(false);

		GUILayout.BeginHorizontal();
		GUILayout.Label("Options", NodeEditorGUI.nodeLabelBoldCentered);
		if (GUILayout.Button("+", GUILayout.Width(20)))
		{
			AddNewOption();
			IssueEditorCallBacks();
		}

		GUILayout.EndHorizontal();
		GUILayout.Space(5);

		DrawOptions();

		GUILayout.ExpandWidth(false);
		GUILayout.EndVertical();
		#endregion

	}
	#endif

	private void RemoveLastOption()
	{
		if(_options.Count > 1)
		{
			DataHolderForOption option = _options.Last();
			_options.Remove(option);
			DeleteConnectionPort(dynamicConnectionPorts.Count-1);
		}
	}
	#if UNITY_EDITOR
	private void DrawOptions()
	{
		EditorGUILayout.BeginVertical();
		for (var i = 0; i < _options.Count; i++)
		{
			DataHolderForOption option = _options[i];
			GUILayout.BeginVertical();
			GUILayout.BeginHorizontal();
			EditorGUILayout.LabelField(i + ".", GUILayout.MaxWidth(15));
			option.OptionDisplay = EditorGUILayout.TextArea(option.OptionDisplay, GUILayout.MinWidth(80));
			((ValueConnectionKnob)dynamicConnectionPorts[i]).SetPosition();
			if (GUILayout.Button("‒", GUILayout.Width(20)))
			{
				_options.RemoveAt(i);
				DeleteConnectionPort (i);
				i--;
			}

			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
			GUILayout.Space(4);
		}
		GUILayout.EndVertical();
	}
	#endif

	private void AddNewOption()
	{
		DataHolderForOption option = new DataHolderForOption {OptionDisplay = "Write Here"};
		CreateValueConnectionKnob(dynaCreationAttribute);
		_options.Add(option);
	}

	//For Resolving the Type Mismatch Issue
	private void IssueEditorCallBacks()
	{
		NodeEditorCallbacks.IssueOnAddConnectionPort (dynamicConnectionPorts[_options.Count - 1]);
	}

	public override BaseDialogNode Input(int inputValue)
	{
		/*
		switch (inputValue)
		{
		case (int)EDialogInputValue.Next:
			break;

		case (int)EDialogInputValue.Back:
			if (IsAvailable(toPreviousOUT))
				return getTargetNode(toPreviousOUT);
			break;

		default:
			//if(Outputs[_options[inputValue].dynamicConnectionPortsIndex].GetNodeAcrossConnection() != default(Node))
			//	return Outputs[_options[inputValue].dynamicConnectionPortsIndex].GetNodeAcrossConnection() as BaseDialogNode;
			//I think we -2 for next and back, but not really sure yet
			//TODO is this right?
			Debug.Log("checking dynamic connection port " + inputValue);
			if (IsAvailable (dynamicConnectionPorts [inputValue]))
				return getTargetNode (dynamicConnectionPorts [inputValue]);
			break;
		}
		*/
		return null;
	}

	public override bool IsBackAvailable()
	{
		return IsAvailable (toPreviousOUT);
	}

	public override bool IsNextAvailable()
	{
		return false;
	}

	[Serializable]
	class DataHolderForOption
	{
		public string OptionDisplay;
		//public int dynamicConnectionPortsIndex;				
	}

	public List<string> GetAllOptions()
	{
		return _options.Select(option => option.OptionDisplay).ToList();
	}
}