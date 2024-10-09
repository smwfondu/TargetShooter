using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsHolder : MonoBehaviour
{
    private float spawnTime = 300;
    public TextMeshProUGUI spawnTimeShower;
    public Slider spawnTimeSlider;

    private float despawnTime = 300;
    public TextMeshProUGUI despawnTimeShower;
    public Slider despawnTimeSlider;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public float GetSpawnTime()
    {
        return spawnTime;
    }

    public float GetDespawnTime()
    {
        return despawnTime;
    }

    private void Update()
    {
        if(spawnTimeSlider != null)
        {
            spawnTime = spawnTimeSlider.value;
            spawnTimeShower.text = "Spawn Time = " + spawnTime + " Frames";

            despawnTime = despawnTimeSlider.value;
            despawnTimeShower.text = "Despawn Time = " + despawnTime + " Frames";
        }
    }
}
