using UnityEngine;
using System.Collections;

public class Event8 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "8";
    }
}
