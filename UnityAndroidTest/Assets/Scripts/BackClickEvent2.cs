using UnityEngine;
using System.Collections;

public class BackClickEvent2 : EventScript
{

    public override void ClickAction()
    {
        base.ClickAction();
        DunGeonCtrl.Back();

    }
}
