﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playgame : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("Game");
    }
    public void back()
    {
        SceneManager.LoadScene("book");
    }
}
