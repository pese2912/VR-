using UnityEngine;
using System.Collections;

public class GrabbingEvent:  GrabbingHand_Gesture{

	// Use this for initialization

    public override void DoAction()
    {
        ShortcutController scController = GameObject.Find("Direction ShortCut").GetComponent<ShortcutController>();
        if (!scController.IsAppearing)
            scController.Appear();
        

    }
}
