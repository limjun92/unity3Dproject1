using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //EnemyAttack();
        //EnemyAttack();
        //EnemyAttack();

        //Debug.Log(ThisYear());

        Debug.Log(NextYear(2025));

        Debug.Log("더하기1 " + PlusNumber(3, 97));

        Debug.Log("더하기2 " + PlusNumber(77));

        Debug.Log("빼기 " + MinusNumber(3, 97));

        Debug.Log("곱하기 " + multi(3, 97));

        Debug.Log("나누기 " + divi(3, 97));

        Debug.Log("나머지 " + divi2(3, 97));


    }

    //void EnemyAttack()
    //{
    //    Debug.Log("Enemy Attack");
    //    Debug.Log("Enemy Damage");
    //    Debug.Log("Enemy HP UI Update");
    //}

    //int ThisYear()
    //{
    //    return 2025;
    //}

    int NextYear(int thisYear)
    {
        int nextYear = thisYear + 1;
        return nextYear;
    }

    int PlusNumber(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    int PlusNumber(int a)
    {
        return a;
    }

    int MinusNumber(int a, int b)
    {
        int sum = a - b;
        return sum;
    }
    int multi(int a, int b)
    {
        int sum = a * b;
        return sum;
    }
    int divi(int a, int b)
    {
        int sum = b / a;
        return sum;
    }
    int divi2(int a, int b)
    {
        int sum = b % a;
        return sum;
    }

}
