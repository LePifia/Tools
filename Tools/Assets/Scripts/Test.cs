using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Test : EditorWindow
{

    VisualElement container;


    [MenuItem("Testing/TestWindow")]
    public static void ShowWindow()
    {
       Test window = GetWindow<Test>();
       window.titleContent = new GUIContent("TestWindow");
       window.minSize = new Vector2(250, 250);
    }   


    public void CreateGUI(){
        container = rootVisualElement;
        VisualTreeAsset visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/datafromUi.uxml");
        container.Add(visualTreeAsset.Instantiate());

        StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/test.uss");
        container.styleSheets.Add(styleSheet);
    }
}
