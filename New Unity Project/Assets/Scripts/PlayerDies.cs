﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDies : MonoBehaviour
{
    private CheckDash _voided;

    private void Start()
    {
        _voided = GetComponent<CheckDash>();
    }

    private void Update()
    {
        if (_voided.Charplace == CheckDash.Place.VOID && _voided.Charplace!= CheckDash.Place.GROUND)
        {
            Invoke("Dies", time: 0.3f);
        }

    }

    void Dies()
    {
        SceneManager.LoadScene(1);
    }
}
