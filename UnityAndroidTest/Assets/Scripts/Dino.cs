using UnityEngine;
using System.Collections;

public class Dino : MonoBehaviour
{

    private Transform playerTr;
    public static int cnt = 0;
    // Use this for initialization
    void Start()
    {
        playerTr = GameObject.Find("용냉이").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTr.position);
    }
    // xz 평면 회전 보정
    //Vector3 relative = transform.InverseTransformPoint (_Camera.transform.position);
    //float angle = Mathf.Atan2 (relative.x, relative.z) * Mathf.Rad2Deg;
    //if (_ShortcutSettings.Type == ShortcutType.Arc) {
    //   gameObject.transform.localRotation = Quaternion.Euler (new Vector3 (180 - angle, 0, 0));
    //} 
    //else if (_ShortcutSettings.Type == ShortcutType.Stick) {
    //gameObject.transform.localRotation = Quaternion.Euler (new Vector3 (360-angle, 180, 180));
    //}
}
