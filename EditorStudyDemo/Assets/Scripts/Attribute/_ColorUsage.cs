using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class _ColorUsage : MonoBehaviour {

    [ColorUsage(false)]// 用于颜色属性    flase 不可以调整透明度 true 可以调整透明度
    public Color color;
    [ContextMenu("Debug")]
     void Show()
    {

        Debug.Log(color);
    }
   
}
