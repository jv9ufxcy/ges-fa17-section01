﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScreen : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("demoscene");
    }
    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("creditsscene");
    }
    public void TitleButtonClicked()
    {
        SceneManager.LoadScene("titlescene");
    }
}