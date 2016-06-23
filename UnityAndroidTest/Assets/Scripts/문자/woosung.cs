using UnityEngine;
using System.Collections;

public class woosung :  EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().IsphoneNum = true;
        AndroidManager.GetInstance().phoneNum = "01051350829";

        ShortcutController _controller = GameObject.Find("WillshortCut").GetComponent<ShortcutController>();

        if (!_controller.IsAppearing)
        {
            _controller.Appear();
        }

        _controller = GameObject.Find("PhoneShortCut1").GetComponent<ShortcutController>();
        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }
        _controller = GameObject.Find("PhoneShortCut2").GetComponent<ShortcutController>();
        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }
        _controller = GameObject.Find("PhoneShortCut3").GetComponent<ShortcutController>();
        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }
        _controller = GameObject.Find("PhoneShortCut4").GetComponent<ShortcutController>();
        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }
        _controller = GameObject.Find("즐겨찾기ShortCut").GetComponent<ShortcutController>();
        if (_controller.IsAppearing)
        {
            _controller.Disappear();
        }
    }
	
}
