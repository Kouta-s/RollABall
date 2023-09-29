using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayExample : MonoBehaviour
{
    private void Awake()
    {
        ShowTime();
    }


    void ShowTime()
    {
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é
    }


    private void Start()
    {
        // ‡@
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
        // ‡A
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        colors.Remove("Green");
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }
        // ‡B
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };
        if (fruits.Contains("Cherry"))
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚é");
        }
        else
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚È‚¢");
        }
    }

}