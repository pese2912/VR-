using UnityEngine;
using System.Collections;

public class q : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "q";
    }

}
