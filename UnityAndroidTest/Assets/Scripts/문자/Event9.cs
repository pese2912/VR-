using UnityEngine;
using System.Collections;

public class Event9 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "9";
    }
}
