using UnityEngine;
using System.Collections;

public class i : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "i";
    }

}

