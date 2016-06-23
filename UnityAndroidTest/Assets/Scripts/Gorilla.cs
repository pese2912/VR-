using UnityEngine;
using System.Collections;

public class Gorilla : MonoBehaviour
{
    public enum MonsterState { idle,run, attack };
    public MonsterState monsterState = MonsterState.idle;
    public MonsterState MState { get { return monsterState; } set { monsterState = value; } } 
    public Animation anim;
    public GameObject bloodEffect;
    private Transform monsterTr;
    private Transform playerTr;
    private NavMeshAgent nvAgent;
    private Quaternion rot;
    Vector3 playerRot;
    Vector3 camRot;
    public float traceDist = 30f;
    public float attackDist = 10f;

    // Use this for initialization
    void Start()
    {
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
            yield return new WaitForSeconds(5f);

            if (monsterState == MonsterState.run)
                nvAgent.speed += 0.5f;
            
        }
    }
 

    IEnumerator CheckMonsterState()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            float dist = Vector3.Distance(playerTr.position, monsterTr.position);
            print(dist);
            if (dist <= attackDist)
            {
                monsterState = MonsterState.attack;
            }
            else if(dist <=traceDist)
            {
                monsterState = MonsterState.run;
            }
            else
            {
                monsterState = MonsterState.idle;
            }

        }
    }

    IEnumerator MonsterAction()
    {
        while (true)
        {
            switch (monsterState)
            {
                case MonsterState.idle:
                    nvAgent.Stop();
                    anim.Play();
                    break;
                case MonsterState.run:
                    nvAgent.destination = playerTr.position;
                    nvAgent.Resume();
                    
                    anim.Play("Run");
                    break;
               

                case MonsterState.attack:
                     playerRot = new Vector3(0, 0, rot.eulerAngles.z);
                     camRot = new Vector3(rot.eulerAngles.x, 0, 0);
                    anim.Play("Attack Boxing");
                    nvAgent.Stop();
                    //Handheld.Vibrate();
                    GameObject blood1 = (GameObject)Instantiate(bloodEffect, playerTr.position + new Vector3(0f, playerTr.localScale.y * 2 - 1f, playerRot.z - 1f), rot);
                    Destroy(blood1, 0.1f);
                    Dino.cnt++;

                    if (Dino.cnt > 1500)
                    {
                       Application.LoadLevel("secondscene");
                    }
                    break;
            }
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //nvAgent.destination = playerTr.position;
        //this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(nvAgent.transform.rotation.x, nvAgent.transform.rotation.y, nvAgent.transform.rotation.z);
        //this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(this.GetComponent<Transform>().transform.rotation.x, this.GetComponent<Transform>().transform.rotation.y + 180f, this.GetComponent<Transform>().transform.rotation.z);
        //Quaternion rot = gameObject.transform.localRotation;
        //this.GetComponent<Transform>().transform.rotation = Quaternion.Euler(0, 180f, 0);
        //gameObject.transform.localRotation = Quaternion.Euler(rot.x, rot.y+180f, rot.z);
    }
}
