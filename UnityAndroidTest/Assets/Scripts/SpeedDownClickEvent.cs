using UnityEngine;
using System.Collections;

public class SpeedDownClickEvent : EventScript
{

    public override void ClickAction()
    {
        base.ClickAction();
        Ctrl.SpeedDown();

    }
}
