using UnityEngine;
using System.Collections;

public class m : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "m";
    }

}
