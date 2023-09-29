using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    int integerNumber;

    private void Start()
    {














        Debug.Log("C:Users\\Username\\Documents");



        int number = 23; // 0から51までの任意の数

        string[] suits = { "ハート", "ダイヤ", "クラブ", "スペード" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        string suit = suits[number / 13];
        string rank = ranks[number % 13];

        Debug.Log($"{suit}の{rank}");


        int x = 5;
        int y = 0;
        if (x > y)
        {
            Debug.Log("xはyより大きい");
        }

        string name1 = "john";
        string name2 = "john";
        if (name1 == name2)
        {
            Debug.Log("二つの名前は同じです");
        }

        int age = 0;
        if (age >= 20)
        {
            Debug.Log("成人です");
        }
        else
        {
            Debug.Log("未成年です");
        }



        int a = 10;
        int b = 4;

        if (a >= 10 && a != 15 && b <= 5)
        {
            // 条件を満たす処理
        }


        bool isRaining = true;
        bool hasUmbrella = true;
        // 雨が降っていない、または雨が降ってるが傘を持っている場合
        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("家を出る。");
        }




        int n = 10; // 任意のn

        while (n > 0)
        {
            if (n % 2 == 0)  // n が偶数の場合
            {
                n /= 2;
            }
            else  // n が奇数の場合
            {
                n -= 1;
            }

            Debug.Log(n);// 5,4,2,1,0
        }




        int[] numbers = {5, 8, 12, 7, 3};
        Debug.Log(numbers[3]);


        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        Debug.Log(fruits[3]);

        //int[] scores = { 78, 85, 90, 72, 88, 60 };
        //int sum = 0;
        //foreach (int score in scores)
        //{
        //    sum += score;
        //}
        //Debug.Log(sum);

        int[] scores = { 50, 80, 60, 80, 90 };
        
        foreach (var score in scores)
        {
            Debug.Log(score);// 50,80,60,80,90
        }



        float number1 = 12.34f;
        int number2;
        // 以下の行に型キャストを行い、number1をint型にキャストして、number2に代入してください。
        number2 = (int)number1;
        Debug.Log(number2); // 12


    }

    private int distance = 10;

    private void Update()
    {
        do
        {
            distance -= 1;
            Debug.Log(distance);

            if (distance == 0)
            {
                Debug.Log("目的地に到着しました!");
                gameObject.SetActive(false);
            }

        } while (distance > 0);
    }



}

public class Person
{
    private string name;

    public string GetName
    {
        get { return name; }
    }

    public string SetName
    {
        set
        {
            // !string.IsNullOrEmpty(value)でも可です
            if (value == string.Empty || value != null)
            {
                name = value;
            }
        }
    }
}


public class Rectangle
{
    private float width;
    private float height;
    public float SetWidth
    {
        set { width = value; }
    }

    public float SetHeight
    {
        set { height = value; }
    }

    public float GetArea
    {
        get
        {
            return width * height;
        }
    }
}





