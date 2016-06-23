using UnityEngine;
using System.Collections;

public class MonsterCtrl : MonoBehaviour {

    public enum MonsterState { run, attack };
    public MonsterState monsterState = MonsterState.run;
    public Animation anim;
    public GameObject bloodEffect;
    private Transform monsterTr;
    private Transform playerTr;
    private Transform tmp;
    private NavMeshAgent nvAgent;

    public float attackDist = 10.0f;

    private bool isRunning = true;

	// Use this for initialization
	void Start () {



        anim = this.gameObject.GetComponent<Animation>();
        monsterTr = this.gameObject.GetComponent<Transform>();
        playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();
        nvAgent.destination = playerTr.position;
        StartCoroutine("CheckMonsterState");
        StartCoroutine("MonsterAction");
        StartCoroutine("SpeedUp");
	}

    IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            if (isRunning)
            {
                nvAgent.speed += 5;
            }
        }
    }

    IEnumerator CheckMonsterState()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.2f);
            float dist = Vector3.Distance(playerTr.position , monsterTr.position);
            print(dist);
            if(dist <=attackDist)
            {
                monsterState = MonsterState.attack;
     
                
            }
            else
            {
                monsterState = MonsterState.run;
             
            }
        }
    }

    IEnumerator MonsterAction()
    {
        while (true)
        {
            switch(monsterState)
            {
                case MonsterState.run:
                    nvAgent.destination = playerTr.position;
                    nvAgent.Resume();
                    CamShake.shakeAmount = 0.7f;
                    anim.Play("Allosaurus_Run"); 
                    break;
                case  MonsterState.attack:
                    anim.Play("Allosaurus_Attack02");
                    nvAgent.Stop();
                    CamShake.shakeAmount = 2f;
                    
                    //print(monsterTr.localPosition);
                    GameObject blood1 = (GameObject)Instantiate(bloodEffect, playerTr.position + new Vector3(0f, playerTr.localScale.y * 2 - 1f,  playerTr.localScale.y/2-5f), Quaternion.identity);
                    Destroy(blood1,0.1f);
                    Dino.cnt++;
           
                    if (Dino.cnt > 1000)
                    {
                      Application.LoadLevel("secondscene");
                    }
                    break;            
            }
            yield return null;
        }
    } 
	// Update is called once per frame
	void Update () {
        //nvAgent.destination = playerTr.position;
        //this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(nvAgent.transform.rotation.x, nvAgent.transform.rotation.y, nvAgent.transform.rotation.z);
        //this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(this.GetComponent<Transform>().transform.rotation.x, this.GetComponent<Transform>().transform.rotation.y + 180f, this.GetComponent<Transform>().transform.rotation.z);
        //Quaternion rot = gameObject.transform.localRotation;
        this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(0, 180f,0);
        //gameObject.transform.localRotation = Quaternion.Euler(rot.x, rot.y+180f, rot.z);
	}
}
