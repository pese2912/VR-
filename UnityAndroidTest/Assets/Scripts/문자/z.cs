using UnityEngine;
using System.Collections;

public class z : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "z";
    }
}
