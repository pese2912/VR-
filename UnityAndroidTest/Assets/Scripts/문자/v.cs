using UnityEngine;
using System.Collections;

public class v : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "v";
    }

}
