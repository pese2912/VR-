using UnityEngine;
using System.Collections;

public class f : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "f";
    }

}

