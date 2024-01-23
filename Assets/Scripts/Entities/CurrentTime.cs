using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTime : MonoBehaviour
{
    TextMeshProUGUI timeTxt;

    private void Awake()
    {
        timeTxt = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTxt.text = GetCurrentTime();
    }

    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}
