using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    private int lastYear = 2024;
    public int nextYear = 2026;

    public float pi;

    public string myName;

    public Boolean check;

    int hp = 90;
    // ������ ���۵Ǹ� �ѹ� ����
    void Start()
    {
        int thisYear = 2025;
        Debug.Log("���ش� : " + thisYear + "�Դϴ�.");
        Debug.Log("�۳��� : " + lastYear + "�Դϴ�.");
        Debug.Log("������ : " + nextYear + "�Դϴ�.");

        pi = 3.14f;
        Debug.Log("pi�� : " + pi + "�Դϴ�.");

        myName = "jun";
        Debug.Log("�̸��� : " + myName + "�Դϴ�.");

        check = true;
        Debug.Log("bool�� : " + check + "�Դϴ�.");

        hp = hp - 100;

        if(hp <= 0)
        {
            Debug.Log("���� ����");
        }
    }

    // ������ ���۵ǰ� �� �����Ӹ��� �ݺ��Ǿ� ����
    void Update()
    {
        Debug.Log("�۳�� : " + lastYear + "�Դϴ�.");
        Debug.Log("����� : " + nextYear + "�Դϴ�.");
    }
}
