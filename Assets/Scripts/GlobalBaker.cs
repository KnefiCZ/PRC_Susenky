﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 10; //origina value is 50
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;

    void Update () {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Pekařů: " + numberOfBakers + " @ " + bakePerSec + " sušenek za sekundu.";
        fakeText.GetComponent<Text>().text = "Koupit pekaře - " + bakerValue + ",- Czk";
        realText.GetComponent<Text>().text = "Koupit pekaře - " + bakerValue + ",- Czk";

        if (currentCash >= bakerValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
