﻿using UnityEngine;
using System.Collections;

public class GrabbingHandGestureEx : GrabbingHand_Gesture {

    int n = 0;
    Color[] color = { Color.red, Color.blue, Color.cyan, Color.yellow, Color.green };
    public override void DoAction()
    {
       
        GameObject obj = GameObject.Find("Cube");
        obj.GetComponent<Renderer>().material.color = color[n];
        n++;
        if (n == 5)
        {
            n = 0;
        }
        System.Threading.Thread.Sleep(100);
    }
}
