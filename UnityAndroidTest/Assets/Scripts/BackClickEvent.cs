using UnityEngine;
using System.Collections;

public class BackClickEvent : EventScript
{

    public override void ClickAction()
    {
        base.ClickAction();
        Ctrl.Back();

    }
}
