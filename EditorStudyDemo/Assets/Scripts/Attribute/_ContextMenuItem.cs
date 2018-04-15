using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ContextMenuItem : MonoBehaviour {

    [ContextMenu("ContextMenu")]//点开脚本的小齿轮时出现选项
    void ContextMenu()
    {
        Debug.Log("ContextMenu");
    }
   

    [ContextMenuItem("ContextMenuItem","ContextMenuItem")]//右键属性时调用指定的方法
    public string input;
    
    void ContextMenuItem()
    {
        Debug.Log("ContextMenuItem"+input);
    }


}
