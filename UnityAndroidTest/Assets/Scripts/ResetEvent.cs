using UnityEngine;
using System.Collections;

public class ResetEvent : EventScript {
    public override void ClickAction()
    {
        base.ClickAction();
        Application.LoadLevel("MEP_Cave_Scene");
    }
	
}
