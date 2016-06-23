using UnityEngine;
using System.Collections;

public class c : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "c";
    }

}
