using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

[CustomEditor(typeof(Tilemap))]
public class BasicTileMapEditor : Editor {

	public override void OnInspectorGUI()
	{
		/*Tilemap theTarget = (Tilemap)target;
		theTarget.animationFrameRate = EditorGUILayout.FloatField("Animation Frame Rate: ", theTarget.animationFrameRate);*/
		DrawDefaultInspector();
	}
}
