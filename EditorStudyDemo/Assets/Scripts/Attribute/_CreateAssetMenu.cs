using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Name")]//在asset 创建面板中添加选项
public class ItemReference : ScriptableObject
{
    [SerializeField]//序列化到面板
    [Multiline(10)]//将面板设为10行
    private string description;
    [SerializeField, Range(0, 64)] //将属性值限制咋0到64之间
    private float stackSize;
   
}