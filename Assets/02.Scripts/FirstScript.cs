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

    // 게임이 시작되면 한번 실행
    void Start()
    {
        int thisYear = 2025;
        Debug.Log("올해는 : " + thisYear + "입니다.");
        Debug.Log("작년은 : " + lastYear + "입니다.");
        Debug.Log("내년은 : " + nextYear + "입니다.");

        pi = 3.14f;
        Debug.Log("pi는 : " + pi + "입니다.");

        myName = "jun";
        Debug.Log("이름은 : " + myName + "입니다.");

        check = true;
        Debug.Log("bool은 : " + check + "입니다.");

        hp = hp - 100;

        if(hp <= 0)
        {
            Debug.Log("게임 오버");
        }
        hp = 100;
    }

    // 상수

    const int DANGER_HP = 40;
    const int WARNING_HP = 60;
    const int DEAD_HP = 0;

    public enum Fruit
    {
        APPLE, BANANA, PEACH, ORANGE
    }

    public Fruit myFruit;

    // 게임이 시작되고 매 프레임마다 반복되어 실행
    void Update()
    {
        //Debug.Log("작년는 : " + lastYear + "입니다.");
        //Debug.Log("내년는 : " + nextYear + "입니다.");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp = hp - 20;
            Debug.Log(hp);
            //if (hp <= 0)
            //{
            //    Debug.Log("게임 오버!");
            //}
            //else if(hp<=40)
            //{
            //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
            //    Debug.Log("비상!!!");
            //}
            //else if (hp <= 60)
            //{
            //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
            //    Debug.Log("조심하세요!!!");
            //}
            //else
            //{
            //    Debug.Log("현재 체력은 : " + hp + " 입니다.");
            //}
            //switch (hp)
            //{
            //    case DEAD_HP:
            //        Debug.Log("게임 오버!");
            //        break;
            //    case DANGER_HP:
            //        Debug.Log("현재 체력은 : " + hp + " 입니다.");
            //        Debug.Log("비상!!!");
            //        break;
            //    case WARNING_HP:
            //        Debug.Log("현재 체력은 : " + hp + " 입니다.");
            //        Debug.Log("조심하세요!!!");
            //        break;
            //    default:
            //        Debug.Log("기본 메시지 입니다.");
            //        break;
            //}
            switch (myFruit)
            {
                case Fruit.ORANGE:
                    Debug.Log("ORANGE 맛있어!");
                    break;
                case Fruit.BANANA:
                    Debug.Log("BANANA 맛있어!");
                    break;
                case Fruit.APPLE:
                    Debug.Log("APPLE 맛있어!");
                    break;
                case Fruit.PEACH:
                    Debug.Log("PEACH 맛있어!");
                    break;
            }
        }
    }
}
