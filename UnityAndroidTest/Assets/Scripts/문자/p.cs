using UnityEngine;
using System.Collections;

public class p : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "p";
    }

}
