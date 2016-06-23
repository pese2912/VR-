using UnityEngine;
using System.Collections;

public class  Event0: EventScript {

    public override void ClickAction()
    {
        AndroidManager.GetInstance().phoneNum += "0";
    }
}
