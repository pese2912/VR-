using UnityEngine;
using System.Collections;

public class h : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "h";
    }

}
