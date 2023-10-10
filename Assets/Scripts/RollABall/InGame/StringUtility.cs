using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringUtility
{
    public static string SecondsToTwoDecimalPlaces(float time)
    {
        return time.ToString("F2");
    }
}
