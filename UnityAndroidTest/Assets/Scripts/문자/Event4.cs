using UnityEngine;
using System.Collections;

public class Event4 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "4";

    }
}
