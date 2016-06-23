using UnityEngine;
using System.Collections;

public class Event1 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "1";
    }
}
