using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; set; } = null;

    public Text _timerText = null;

    private Text timerText { get { return _timerText; } }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetTimer(float timer)
    {
        timerText.text = "Timer:" + timer.ToString("F1");
    }
}
