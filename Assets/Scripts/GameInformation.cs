using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameInformation
{
    public static int Score = 0;

    internal static void GameOver()
    {
        SceneManager.LoadScene("title");
    }
}
