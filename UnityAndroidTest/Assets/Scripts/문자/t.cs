using UnityEngine;
using System.Collections;

public class t : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "t";
    }

}
