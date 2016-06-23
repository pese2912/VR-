using UnityEngine;
using System.Collections;

public class GrabbingEvent2: GrabbingHand_Gesture{

    public GameObject gorillas;

    public override void DoAction()
    {
        ShortcutController scController = GameObject.Find("Direction ShortCut").GetComponent<ShortcutController>();
        if (scController.IsAppearing)
            scController.Disappear();

   

        for (int i = 0; i < gorillas.transform.childCount; i++)
        {
            Gorilla gorilla = gorillas.transform.GetChild(i).GetComponent<Gorilla>();
            gorilla.MState = Gorilla.MonsterState.idle;
        }
      
    }
	// Use this for initialization
	
}
