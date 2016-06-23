using UnityEngine;
using System.Collections;

public class d : EventScript
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "d";
    }

}

