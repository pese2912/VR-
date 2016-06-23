using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class testGUI : MonoBehaviour
{
    public int cnt = 0;
    public float[] list ;
    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }
    void Awake()
    {
       // plane.AddComponent<Renderer>();
    }

    void Start()
    {
        cnt = 0;
        list = new float[8] { 50f, 0f, -50f, -90f, 230f, 180f, 150f, 90f };
        AndroidManager.GetInstance().CallJavaFunc("javaTestFunc", "UnityJavaJarTest");       
        StartCoroutine("picture");
 
    }

    IEnumerator picture()
    {
        for (int i = 1; i <= 1400; i++)
        {
            AndroidManager.GetInstance().CallJavaFunc("showShareAvailableApps", "UnityJavaJarTest");
            yield return new WaitForSeconds(1f);
            float deg = 0;
            if (i % 8 == 0)
            {
                deg = 360 / 8 * 8;
            }
            else
            {
                deg = 360 / 8 * (i % 8);
            }
            float radian = deg * Mathf.PI / 180;
            float x = 0f + 8f * Mathf.Cos(radian);
            float z = 0f + 8f * Mathf.Sin(radian);
            string name = "Plane (" + i + ")";
            GameObject.Find("picture").transform.FindChild(name).gameObject.SetActive(true);
            GameObject plane = GameObject.Find(name);
            plane.transform.position = new Vector3(x, 0, z);
            plane.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            plane.transform.rotation = Quaternion.Euler(90f, list[cnt], 0f);
            cnt = (cnt + 1) % 8;
            plane.name = AndroidManager.GetInstance().name;
            imgageTest.Gname = AndroidManager.GetInstance().name;
            plane.AddComponent<imgageTest>();
            plane.AddComponent<come>();
            yield return new WaitForSeconds(2f);
        }
    }

    void OnGUI()
    {
       
        GUI.Label(new Rect(100, 100, 200, 200), AndroidManager.GetInstance().statement);

        GUI.Label(new Rect(300, 100, 200, 200), AndroidManager.GetInstance().phoneNum);
    }

}