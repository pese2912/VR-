using UnityEngine;
using System.Collections;

public class l : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "l";
    }

}
