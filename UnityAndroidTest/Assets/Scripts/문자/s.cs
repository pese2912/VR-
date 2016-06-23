using UnityEngine;
using System.Collections;

public class s : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "s";
    }

}
