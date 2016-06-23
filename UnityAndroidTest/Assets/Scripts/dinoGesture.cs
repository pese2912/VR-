using UnityEngine;
using System.Collections;

public class dinoGesture : GrabbingHand_Gesture {

    public override void DoAction()
    {
        //base.DoAction();
        ShortcutController _controller = GameObject.Find("Direction ShortCut").GetComponent<ShortcutController>();

        if (!_controller.IsAppearing)
        {
            _controller.Appear();
        }
    }
	
}
