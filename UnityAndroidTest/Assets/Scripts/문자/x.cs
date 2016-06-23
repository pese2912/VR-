using UnityEngine;
using System.Collections;

public class x : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "x";
    }

}
