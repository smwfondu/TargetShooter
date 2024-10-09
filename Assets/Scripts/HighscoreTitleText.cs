using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreTitleText : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
    }

    private void Update()
    {
        text.text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
    }
}
