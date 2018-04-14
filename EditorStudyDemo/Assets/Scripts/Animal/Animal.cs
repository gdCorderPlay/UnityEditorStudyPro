using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/// <summary>
/// 动物的基类
/// </summary>

public class Animal : MonoBehaviour {

    /// <summary>
    /// 名称
    /// </summary>
    public string animalName;
    /// <summary>
    /// 寿命
    /// </summary>
    public int life;

    private int hp;
    public virtual void Show()
    {
        Debug.Log(string .Format("我是一只{0}，我可以活{1}年,我的体力值为{2}",animalName,life,hp));
    }
    private void Start()
    {
        Show();
    }
}
