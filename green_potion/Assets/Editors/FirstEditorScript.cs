using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player))]
public class FirstEditorScript : Editor {
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
	}
}
