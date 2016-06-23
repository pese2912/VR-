using UnityEngine;
using System.Collections;

public class WillEvent : EventScript {

    public override void ClickAction()
    {
        ShortcutController _controller = GameObject.Find("OpShortCut").GetComponent<ShortcutController>();

        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }

        _controller = GameObject.Find("WillshortCut").GetComponent<ShortcutController>();

        if (!_controller.IsAppearing)
        {
            _controller.Appear();
        }
    }
    
	
}
