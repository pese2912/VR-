using UnityEngine;
using System.Collections;

public class bruno : MonoBehaviour {
    public Animation anim;
    private Transform monsterTr;
    public enum MonsterState { run, attack };
    public MonsterState monsterState = MonsterState.run;
	// Use this for initialization
	void Start () {
        anim = this.gameObject.GetComponent<Animation>();
        monsterTr = this.gameObject.GetComponent<Transform>();
        StartCoroutine("MonsterAction");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator MonsterAction()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            if (monsterState == MonsterState.attack)
            {
                anim.Play("bite_or_attack_slower");
                monsterState = MonsterState.run;
                continue;
            }
            else if (monsterState == MonsterState.run)
            {
                anim.Play("walk");
                monsterState = MonsterState.attack;
                continue;
            }
            print(monsterState);
        }

    }
}
