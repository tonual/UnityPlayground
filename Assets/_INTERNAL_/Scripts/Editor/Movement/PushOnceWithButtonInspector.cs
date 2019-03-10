using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(PushOnce))]
public class PushOnceInspector : InspectorBase
{
	private string explanation = "The GameObject will move once at the push of a button, as if a pulse or an invisible force was applying a pulse to it.";
	private string absoluteTip = "TIP: The GameObject will always move in the direction chosen regardless of its orientation.";
	private string relativeTip = "TIP: The GameObject will move in the direction chosen relative to its orientation.";

	public override void OnInspectorGUI()
	{
		GUILayout.Space(10);
		EditorGUILayout.HelpBox(explanation, MessageType.Info);

		base.OnInspectorGUI();

		if(serializedObject.FindProperty("relativeAxis").boolValue)
		{
			EditorGUILayout.HelpBox(relativeTip, MessageType.Info);
		}
		else
		{
			EditorGUILayout.HelpBox(absoluteTip, MessageType.Info);
		}
	}
}