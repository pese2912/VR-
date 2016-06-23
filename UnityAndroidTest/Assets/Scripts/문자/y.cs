using UnityEngine;
using System.Collections;

public class y : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "y";
    }

}
