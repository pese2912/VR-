using UnityEngine;
using System.Collections;

public class w : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "w";
    }

}
