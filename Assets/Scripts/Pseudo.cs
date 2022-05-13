using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pseudo : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public string pseudo;

    public void Ok()
    {
        pseudo = txt.text;
    }
}
