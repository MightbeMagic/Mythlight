using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Singletons
{
    [CustomEditor(typeof(AvatarManager))]
    class AvatarManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            EditorGUILayout.HelpBox("This is a help box", MessageType.Info);

            AvatarManager myScript = (AvatarManager)target;
            if (GUILayout.Button("Set Skintone"))
            {
                myScript.SetSkintone();
            }
            if (GUILayout.Button("Set Lineart"))
            {
                myScript.SetLineart();
            }
        }
    }
}