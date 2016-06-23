using UnityEngine;
using System.Collections;

public class Rion : MonoBehaviour
{

    public enum MonsterState { run, attack };
    public MonsterState monsterState = MonsterState.run;
    public Animation anim;
    public GameObject bloodEffect;
    private Transform monsterTr;
    private Transform playerTr;
    private NavMeshAgent nvAgent;
    private  Quaternion rot;
    Vector3 playerRot;
    Vector3 camRot;
    public float attackDist = 8;

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
         
            switch (monsterState)
            {
                case MonsterState.run:
                    nvAgent.destination = playerTr.position;
                    nvAgent.Resume();           
                    anim.Play();
                    break;
                case MonsterState.attack:
                    anim.Play("bite");
                    nvAgent.Stop();
                    //Handheld.Vibrate();
                    playerRot = new Vector3(0, 0, rot.eulerAngles.z);
                     camRot = new Vector3(rot.eulerAngles.x, 0, 0);

                     GameObject blood1 = (GameObject)Instantiate(bloodEffect, playerTr.position + new Vector3(0f, playerTr.localScale.y * 2 - 1f, playerRot.z+1f), rot);
                    Destroy(blood1, 0.1f);
                    Dino.cnt++;

                    if (Dino.cnt > 500)
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
