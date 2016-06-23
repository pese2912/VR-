using UnityEngine;
using System.Collections;

public class DungeonLightUpEvent : EventScript
{
    public Light[] children;
    public override void ClickAction()
    {
        base.ClickAction();
        DunGeonCtrl.Back();

         Light[] children = GameObject.Find("던전").GetComponentsInChildren<Light>();// GetComponent<Light>().intensity += 1;
        foreach(Light child in children)
        {
            child.gameObject.GetComponent<Light>().intensity += 0.5f;
        }
    }
}
