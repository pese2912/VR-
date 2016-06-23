using UnityEngine;
using System.Collections;

public class SizeUpClickEvent : FlipHand_Gesture 
{

    public override void DoAction()
    {
        Ctrl.SizeUp();
    }
}
