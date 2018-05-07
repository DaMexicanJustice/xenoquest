using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeEditorFramework;

public class CanvasTester : MonoBehaviour {

	public NodeCanvas canvas;

	// Use this for initialization
	void Start () {
		foreach(Node n in canvas.nodes) {
			Debug.Log ("Message:" + GetDialogNode (n).dialogLine);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public DialogNode GetDialogNode(Node n) {
		if (n as DialogNode != null) {
			return n as DialogNode;
		}
		return null;
}
	
}
