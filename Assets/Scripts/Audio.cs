using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject UI;
    bool a=true;
    public void foo()
    {
        if(a)foo1();
        else foo2();
        a=!a;
    }
    void foo1()
    {
        UI.SetActive(true);
    }
    void foo2()
    {
        UI.SetActive(false);
    }
    public void switchtooone()
    {
        //do audio change
        Debug.Log("check 1");
    }
     public void switchtotwo()
    {
        //do audio change
        Debug.Log("check 2");
    }
     public void switchtothee()
    {
        //do audio change
        Debug.Log("check 3");
    }

}
