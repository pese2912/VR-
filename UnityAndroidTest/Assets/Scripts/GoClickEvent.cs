using UnityEngine;
using System.Collections;

public class GoClickEvent : EventScript {

    public override void ClickAction()
    {
        base.ClickAction();
        Ctrl.Go();
     
    }
}
