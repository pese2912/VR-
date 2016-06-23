using UnityEngine;
using System.Collections;

public class DunGeonCtrl : MonoBehaviour
{

    public enum PlayerState { idle, run };
    public PlayerState playerState = PlayerState.idle;
    public Animation anim;

    public static float moveSpeed = 5.0f;
    public static float moveRot = 0.5f;
    static private Transform tr = null;
    // GameObject ab;
    static float v;
    static float h;
    static float rot;
    // Use this for initialization
    void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
        anim = this.gameObject.GetComponent<Animation>();
        StartCoroutine("CheckPlayerState");
        StartCoroutine("PlayerAction");

    }

    IEnumerator CheckPlayerState()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);


            if (v != 0)
            {
                playerState = PlayerState.run;

            }
            else
            {
                playerState = PlayerState.idle;
            }
        }
    }

    IEnumerator PlayerAction()
    {
        while (true)
        {
            switch (playerState)
            {
                case PlayerState.idle:

                    CamShake.shakeAmount = 0.7f;
                    anim.Play();
                    break;
                case PlayerState.run:

                    anim.Play("run");
                    CamShake.shakeAmount = 2f;

                    break;
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical"); //1f

        rot = 0f;
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * 0;
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);

    }

    public static void Go()
    {
        v = 1f;
        h = 0;
        rot = 0f;
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * h;
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);
    }
    public static void Back()
    {

        v = -1f;
        h = 0;
        rot = 0f;
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * h;
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);
    }


    public static void SpeedUp()
    {
        moveSpeed += 3f;
    }
    public static void SpeedDown()
    {
        moveSpeed -= 3f;
    }
    public static void SizeUp()
    {
        tr.transform.localScale += new Vector3(3f, 3f, 3f);
    }
    public static void SizeDown()
    {
        tr.transform.localScale += new Vector3(-3f, -3f, -3f);
    }
}

//0, 1.7, 0.45