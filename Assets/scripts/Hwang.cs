using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hwang : MonoBehaviour
{

    public static string str;
    float nooooo; // �����ڸ� ���� ������ private ��� �ν� ( ȸ���򤩤�����)

    public int lol;

    public string msg;

    private int key;

    public readonly string id;

    public Hwang(string _id)
    {
        id = _id;

    }

    public void SetNoo(float val)
    {
        nooooo = val;   
    }

    public float GetNoo()
    {
        return nooooo;
    }

    public void SetKey(int k)
    {
        key = k;
    }

    public int GetKey()
    {
        return key; 
    }
}
