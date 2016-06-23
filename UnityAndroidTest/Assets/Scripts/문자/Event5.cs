using UnityEngine;
using System.Collections;

public class Event5 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "5";

    }
}
