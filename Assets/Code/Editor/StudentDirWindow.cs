using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class StudentDirWindow : EditorWindow {

    [MenuItem("WSEI/Katalog studenta")]
    public static void ShowWindow() {
        EditorWindow.GetWindow(typeof(StudentDirWindow));
    }

    string name, surname, index;

    void OnGUI() {
        GUILayout.Label("Mój folder", EditorStyles.boldLabel);
        name = ValidateString(EditorGUILayout.TextField("Imię", name));
        surname = ValidateString(EditorGUILayout.TextField("Nazwisko", surname));
        index = ValidateString(EditorGUILayout.TextField("Nr indeksu", index));
        if (GUILayout.Button("Stwórz pusty katalog")) {
            System.IO.Directory.CreateDirectory(GetStudendDirPath());
            FileUtil.CopyFileOrDirectory(Application.dataPath+"/Standard Assets/Original scenes", GetStudendDirPath()+"/Scenes");
            AssetDatabase.Refresh();
        }
    }

    string GetStudendDirPath() {
        return Application.dataPath + "/" + GetStudentDirName();
    }

    string ValidateString(string text) {
        text = Regex.Replace(text, "[^\\w\\._]", "");
        return text;
    }

    string GetStudentDirName() {
        return "praca-" + index + "-" + name + "_" + surname;
    }
}