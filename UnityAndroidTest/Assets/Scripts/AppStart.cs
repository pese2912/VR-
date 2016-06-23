using UnityEngine;
using System.Collections;

public class AppStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(80, 40, 200, 200), "YongNaeng World"))
        {
            Application.LoadLevel("firstscene");
        }
        if (GUI.Button(new Rect(280, 240, 200, 200), "YongNaeng Dungeon"))
        {
            Application.LoadLevel("Dungeon");
        }
    }
}
