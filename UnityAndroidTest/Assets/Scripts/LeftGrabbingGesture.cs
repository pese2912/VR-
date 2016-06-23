using UnityEngine;
using System.Collections;

public class LeftGrabbingGesture : GrabbingHand_Gesture {

   
    public override void DoAction()
    {
      
         ShortcutController _controller = GameObject.Find("OpShortCut").GetComponent<ShortcutController>();
        
        if(!_controller.IsAppearing)
        {
            _controller.Appear();
        }
    }
	
}
