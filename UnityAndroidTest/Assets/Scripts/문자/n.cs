using UnityEngine;
using System.Collections;

public class n : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "n";
    }

}
