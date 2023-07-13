using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPlayer : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject optionsSettings;
    [SerializeField] private GameObject toturialSettings;
    [SerializeField] private TextMeshProUGUI timeCount;
    [SerializeField] private TextMeshProUGUI keyCount;
    [SerializeField] private TextMeshProUGUI deathCount;
    [SerializeField] public AudioSource _audio;
    [SerializeField] private UnityEngine.TextAsset _textAsset;

    [SerializeField] public static float timeCounting = 10;
    [SerializeField] private bool timerIsRunning = false;
    public static string KEY_NAME = "MyGame_NAME";


    public List<Account> Accounts { get; set; }

    private static string fileName = null;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        fileName = Application.dataPath + "/Data/Account_Player.csv";

        //panelSettings.SetActive(false);
        //optionsSettings.SetActive(false);
        //ReadData();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Escape)) {
        //    TurnOnPauseMenu(true);
        //}

        if (timerIsRunning)
        {
            if (timeCounting >= 0)
            {
                timeCounting += Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeCounting = 0;
                timerIsRunning = false;
            }
        }

        //timeCount.text = TimeSpan.FromSeconds(timeCounting).ToString("hh':'mm':'ss");
    }

    public void TurnOnPauseMenu(bool isOn)
    {
        if (isOn)
        {
            Time.timeScale = 0f;
            panelSettings.SetActive(true);
        }
        else
        {
            panelSettings.SetActive(false);
            optionsSettings.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void TurnOnOptionMenu(bool isOn)
    {
        if (isOn)
        {
            panelSettings.SetActive(false);
            optionsSettings.SetActive(true);
        }
        else
        {
            panelSettings.SetActive(true);
            optionsSettings.SetActive(false);
        }
    }

    public void TurnOnToturialMenu(bool isOn)
    {
        if (isOn)
        {
            Time.timeScale = 0f;
            toturialSettings.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            toturialSettings.SetActive(false);
        }
    }

    public void TurnOnOffAudio(bool isCheck)
    {
        _audio.GetComponent<AudioSource>().mute = isCheck;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("RunnerGame");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Menu");
    }


    public static void ResetTimeCounting()
    {
        timeCounting = 0;
    }
}
