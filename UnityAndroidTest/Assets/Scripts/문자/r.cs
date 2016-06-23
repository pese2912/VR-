using UnityEngine;
using System.Collections;

public class r : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "r";
    }

}
