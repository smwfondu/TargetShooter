using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShower : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        text.text = "Score: " + GameObject.FindGameObjectWithTag("ScoreHolder").gameObject.GetComponent<ScoreManager>().GetCurrentScore().ToString();
    }
}
