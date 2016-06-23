using UnityEngine;
using System.Collections;

public class Event6 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "6";
    }
}
