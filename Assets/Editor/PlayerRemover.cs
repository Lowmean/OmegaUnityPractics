using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class PlayerRemover : EditorWindow
{
    [MenuItem("Tools/Player Remover")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Reset!");
    }
}
