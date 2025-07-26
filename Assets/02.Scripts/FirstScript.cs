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
    }

    // 게임이 시작되고 매 프레임마다 반복되어 실행
    void Update()
    {
        Debug.Log("작년는 : " + lastYear + "입니다.");
        Debug.Log("내년는 : " + nextYear + "입니다.");
    }
}
