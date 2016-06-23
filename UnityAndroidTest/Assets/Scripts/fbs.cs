using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fbs : MonoBehaviour
{

    private float updateInterval = 1.0f;
    private float lastInterval;
    private float frames = 0.0f;

    private Text text;

    // Use this for initialization
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
        text = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {

            float fps = frames / (timeNow - lastInterval);
            float ms = 1000.0f / Mathf.Max(fps, 0.00001f);
            text.text = ms.ToString("f1") + "ms " + fps.ToString("f2") + "FPS";
            frames = 0;
            lastInterval = timeNow;

        }


    }
}