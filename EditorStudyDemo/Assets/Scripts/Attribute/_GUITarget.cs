using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GUITarget : MonoBehaviour {

    [GUITarget]
    public void Show()
    {
        Debug.Log("Show");
    }
}
