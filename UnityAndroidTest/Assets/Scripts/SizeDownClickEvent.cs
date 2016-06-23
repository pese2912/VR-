using UnityEngine;
using System.Collections;

public class SizeDownClickEvent : FlipHand_Gesture
{
    public override void DoAction()
    {
        //base.DoAction();
        Ctrl.SizeDown();
    }
    
}
