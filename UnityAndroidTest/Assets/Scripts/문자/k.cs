using UnityEngine;
using System.Collections;

public class k : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "k";
    }

}
