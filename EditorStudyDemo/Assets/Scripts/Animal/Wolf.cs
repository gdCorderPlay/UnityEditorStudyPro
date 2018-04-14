using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Animal {


    public int hit;
    public override void Show()
    {
        base.Show();
        Debug.Log("我具有很强的攻击性"+hit);

    }

}
