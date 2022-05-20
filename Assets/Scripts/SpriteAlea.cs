using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpriteAlea : MonoBehaviour
{
    public List<Sprite> sprite = new List<Sprite>();

    public List<string> URL = new List<string>();

    public Image img;
    private void Start()
    {
        int alea = Random.Range(0, sprite.Count);

        img.sprite = sprite[alea];
    }
    
    public void BouttoURL()
    {
        int alea = Random.Range(0, URL.Count);
        
        Application.OpenURL(URL[alea]);
    }
}
