using UnityEngine;
using System.Collections;
public class GoClickEvent2 : EventScript
{
    public override void ClickAction()
    {
        base.ClickAction();
        DunGeonCtrl.Go();
    }
}
