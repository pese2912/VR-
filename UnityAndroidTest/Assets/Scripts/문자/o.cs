using UnityEngine;
using System.Collections;

public class o : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "o";
    }

}
