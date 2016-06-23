using UnityEngine;
using System.Collections;

public class Event2 : EventScript
{

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "2";
    }
}
