using UnityEngine;
using System.Collections;

public class imgageTest : MonoBehaviour {

    public static string url= "http://112.108.40.141/uploads/";
    public GameObject plane;
    public static string Gname;
    public static Renderer renderer;

    void Start()
    {
        plane = GameObject.Find(Gname);
        renderer = plane.GetComponent<Renderer>();
        plane.GetComponent<Transform>().Rotate(new Vector3(0f, 0f, 180f));
        
    }

    IEnumerator render() {
        url = "http://112.108.40.141/uploads/" + Gname;//+ (string)AndroidManager.GetInstance().ImageNames[0];             
             WWW www = new WWW(url);      
            yield return www;
            
            //renderer.material.color = Color.cyan;
            renderer.material.mainTexture = www.texture;
           
    }

    void Update()
    {
        if (!url.Equals("http://112.108.40.141/uploads/" + Gname))
      {
            //print(url);
            StartCoroutine("render");
       }
    }
}
