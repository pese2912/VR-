using UnityEngine;
using System.Collections;

public class b : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "b";
    }

}
