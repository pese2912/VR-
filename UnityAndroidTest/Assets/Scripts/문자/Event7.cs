using UnityEngine;
using System.Collections;

public class Event7 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "7";
    }
}
