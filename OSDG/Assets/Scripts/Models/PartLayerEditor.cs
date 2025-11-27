using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Models
{
    [CustomEditor(typeof(PartLayer))]
    class PartLayerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            PartLayer myScript = (PartLayer)target;
            if (GUILayout.Button("Set Color"))
            {
                myScript.SetLayerColor();
            }
            if (GUILayout.Button("Set Defaults"))
            {
                myScript.SetLayerToDefaults();
            }
        }
    }
}