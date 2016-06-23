using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {
    public float moveSpeed = 10.0f;
    public float moveRot = 0.5f;
    private Transform tr = null;
   public  float v=1f;
   public  float h=0;
   public float rot=0;
	// Use this for initialization
	void Start () {
        tr = this.gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
       
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right) * h;
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * moveRot * Time.deltaTime * rot);
	}
}
