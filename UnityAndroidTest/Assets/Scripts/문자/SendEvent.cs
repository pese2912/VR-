using UnityEngine;
using System.Collections;

public class SendEvent : EventScript {

    public override void ClickAction()
    {
        ShortcutController _controller = GameObject.Find("WillshortCut").GetComponent<ShortcutController>();

        if (_controller.IsAppearing)
        {
             if (AndroidManager.GetInstance().IsphoneNum == true && AndroidManager.GetInstance().Isstatement == true)
            {
                _controller.Disappear();
                AndroidManager.GetInstance().CallJavaFunc2("SmsSend", AndroidManager.GetInstance().phoneNum, AndroidManager.GetInstance().statement);
            }
        }
    }
}
