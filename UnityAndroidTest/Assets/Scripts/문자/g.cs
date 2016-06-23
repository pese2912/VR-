using UnityEngine;
using System.Collections;
public class g : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "g";
    }

}
