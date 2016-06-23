using UnityEngine;
using System.Collections;

public class FlipHandEvent2: FlipHand_Gesture {
    // Use this for initialization
    public Light[] children;
    public override void DoAction()
    {
    
        Light[] children = GameObject.Find("MEP_Cave").GetComponentsInChildren<Light>();// GetComponent<Light>().intensity += 1;
        foreach (Light child in children)
        {
            child.gameObject.GetComponent<Light>().intensity -= 0.03f;
        }

    }
	
}
