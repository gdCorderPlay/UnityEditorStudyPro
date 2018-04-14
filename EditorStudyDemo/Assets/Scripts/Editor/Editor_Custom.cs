using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Animal), true)]
public class Editor_Custom : Editor {

    /// <summary>
    /// 重新简视面板的绘制
    /// </summary>
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Animal animal = target as Animal;
      //SerializedProperty property=  serializedObject.FindProperty("life");
        if (animal.life > 100)
        {
            animal.life = 100;
        }
        //GUI.backgroundColor = Color.cyan;
        // EditorGUILayout.LabelField("setting", EditorStyles.objectFieldThumb);
        // if (animal.life > 10)
        // {
        //   GUI.backgroundColor = Color.red;
        // }
        // else
        //  {
        //GUI.backgroundColor = Color.blue;
        // }
        //int life = IntField("寿命：",animal.life);

        // if (animal.life != life)
        // {
        //   animal.life = life;
        // }
        //serializedObject.Update();
        //GUI.backgroundColor = Color.gray;
        // EditorGUILayout.PropertyField(serializedObject.FindProperty("animalName"));


        //serializedObject.ApplyModifiedProperties();


    }
    /// <summary>
    /// 获取当前的属性面板的输入值
    /// </summary>
    /// <param name="showTitle"> 属性的描述</param>
    /// <param name="showValue"> 属性的值</param>
    /// <returns></returns>
      static  int IntField(string showTitle,int showValue)
    {
        return EditorGUILayout.IntField(showTitle, showValue);
    }
}
