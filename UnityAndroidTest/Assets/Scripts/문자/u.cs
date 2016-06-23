using UnityEngine;
using System.Collections;
public class u : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "u";
    }

}
