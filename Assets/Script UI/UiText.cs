using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UiText : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public Player health;
    public void Update()
    {
       HealthText.text = "Health:" + health.healthui.ToString();
    }

}
