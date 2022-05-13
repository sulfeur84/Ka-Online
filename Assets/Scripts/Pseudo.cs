using UnityEngine;
using TMPro;

public class Pseudo : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public string pseudo;

    public void Ok()
    {
        pseudo = txt.text;
    }
}
