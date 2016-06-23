using UnityEngine;
using System.Collections;

public class a : EventScript 
{
    public override void ClickAction()
    {
        AndroidManager.GetInstance().statement += "a";
    }
	
}
