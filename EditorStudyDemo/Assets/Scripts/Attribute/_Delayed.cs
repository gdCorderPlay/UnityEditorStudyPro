using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Delayed : MonoBehaviour
{

    [Delayed] //在输入数值值当按下确认键时才会改变属性值 不会实时改变
    public int age;
    [Delayed()]
    public float high;
    [Delayed()]
    public string _name;
}
	
