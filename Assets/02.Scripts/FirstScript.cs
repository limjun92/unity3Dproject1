using System;
using System.Collections;
using System.Collections.Generic;

//using System.Diagnostics;
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
        hp = 100;
    }

    // ���

    const int DANGER_HP = 40;
    const int WARNING_HP = 60;
    const int DEAD_HP = 0;

    public enum Fruit
    {
        APPLE, BANANA, PEACH, ORANGE
    }

    public Fruit myFruit;

    // ������ ���۵ǰ� �� �����Ӹ��� �ݺ��Ǿ� ����
    void Update()
    {
        //Debug.Log("�۳�� : " + lastYear + "�Դϴ�.");
        //Debug.Log("����� : " + nextYear + "�Դϴ�.");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;
            Debug.Log(hp);
            //if (hp <= 0)
            //{
            //    Debug.Log("���� ����!");
            //}
            //else if(hp<=40)
            //{
            //    Debug.Log("���� ü���� : " + hp + " �Դϴ�.");
            //    Debug.Log("���!!!");
            //}
            //else if (hp <= 60)
            //{
            //    Debug.Log("���� ü���� : " + hp + " �Դϴ�.");
            //    Debug.Log("�����ϼ���!!!");
            //}
            //else
            //{
            //    Debug.Log("���� ü���� : " + hp + " �Դϴ�.");
            //}
            //switch (hp)
            //{
            //    case DEAD_HP:
            //        Debug.Log("���� ����!");
            //        break;
            //    case DANGER_HP:
            //        Debug.Log("���� ü���� : " + hp + " �Դϴ�.");
            //        Debug.Log("���!!!");
            //        break;
            //    case WARNING_HP:
            //        Debug.Log("���� ü���� : " + hp + " �Դϴ�.");
            //        Debug.Log("�����ϼ���!!!");
            //        break;
            //    default:
            //        Debug.Log("�⺻ �޽��� �Դϴ�.");
            //        break;
            //}
            switch (myFruit)
            {
                case Fruit.ORANGE:
                    Debug.Log("ORANGE ���־�!");
                    break;
                case Fruit.BANANA:
                    Debug.Log("BANANA ���־�!");
                    break;
                case Fruit.APPLE:
                    Debug.Log("APPLE ���־�!");
                    break;
                case Fruit.PEACH:
                    Debug.Log("PEACH ���־�!");
                    break;
            }
        }
    }
}
