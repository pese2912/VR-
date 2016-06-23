using UnityEngine;
using System.Collections;

public class AndroidManager : MonoBehaviour
{
    private AndroidJavaObject curActivity;
    public ArrayList ImageNames= new ArrayList();
    public string name="";
    public  string phoneNum =""; 
    public  string statement="";
    public bool IsphoneNum = false;
    public bool Isstatement = false;

    static AndroidManager _instance;
    public static AndroidManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject("AndroidManager").AddComponent<AndroidManager>();
        }
        return _instance;
    }

    void Awake()
    {
        ///&lt; 현재 활성화된 액티비티 얻어와서 저장
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        curActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
    }
    void Start()
    {

    }

    public void CallJavaFunc(string strFuncName, string strTemp)
    {
        if (curActivity == null)
            return;
        ///&lt; 액티비티안의 자바 메소드 호출
        curActivity.Call(strFuncName, strTemp);
    }
    public void CallJavaFunc2(string strFuncName, string phoneNum, string statement)
    {
        if (curActivity == null)
            return;
        curActivity.Call(strFuncName, phoneNum, statement);
    }


    void setImageNames(string tmp)
    {
        //ImageNames.Add(name);
        name = tmp;
    }
   
     /*
    void setObject(string tmp)
    {
        /*
        GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);     
       
        Cube.AddComponent<imgageTest>();
    
    }

    void SetPackageName(string strPkgName)
    {
        packageName.Add(strPkgName);
    }

    void SetAppName(string strName)
    {
        appName.Add(strName);
    }
    
    void SetTest(string strName)
    {
        tmp = strName;
    }
    void SetTest2(string strName)
    {
        tmp2 = strName;
    }
     * */
}