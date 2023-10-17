using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{
    public Text TimerText;
    private float timerTime = 30f;
    // delegate‚Ì’è‹`
    public delegate void OneSecondsAction();
    public OneSecondsAction OnTimePassed;

    private void Start()
    {
        // 1•bŒã‚Édelegate‚ğŒÄ‚Ño‚·
        Invoke("ExecuteAction", 1f);
    }

    private void ExecuteAction()
    {
        OnTimePassed?.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        if (timerTime < 0)
        {
            TimerText.text = "0";
        }
        else
        {
            TimerText.text = $"{StringUtility.SecondsToTwoDecimalPlaces(timerTime -= Time.deltaTime)}";
        }
    }
}
