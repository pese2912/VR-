using UnityEngine;
using System.Collections;

public class e : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "e";
    }

}
