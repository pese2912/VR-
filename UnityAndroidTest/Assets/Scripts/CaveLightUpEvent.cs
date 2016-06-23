using UnityEngine;
using System.Collections;

public class CaveLightUpEvent : EventScript
{
    public Light[] children;
    public override void ClickAction()
    {
        base.ClickAction();
       

         Light[] children = GameObject.Find("MEP_Cave").GetComponentsInChildren<Light>();// GetComponent<Light>().intensity += 1;
        foreach(Light child in children)
        {
            child.gameObject.GetComponent<Light>().intensity += 0.5f;
        }
    }
}
