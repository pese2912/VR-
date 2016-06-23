using UnityEngine;
using System.Collections;

public class j : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "j";
    }

}
