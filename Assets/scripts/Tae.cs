using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tae : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hwang obj = new Hwang("so_hot");

        obj.SetNoo(0.3f);
        obj.lol = 11;
        obj.msg = "황!!!!!!";
        obj.SetKey(1);
        Hwang.str = "정적이래";

        Debug.Log(obj.id);
        Debug.Log(obj.GetNoo());
        Debug.Log(obj.GetKey());
        Debug.Log(obj.msg);
        Debug.Log(obj.lol);
        Debug.Log(Hwang.str);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
