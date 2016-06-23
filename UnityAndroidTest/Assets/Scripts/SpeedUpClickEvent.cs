using UnityEngine;
using System.Collections;

public class SpeedUpClickEvent : EventScript
{

    public override void ClickAction()
    {
        base.ClickAction();
        Ctrl.SpeedUp();

    }
}
