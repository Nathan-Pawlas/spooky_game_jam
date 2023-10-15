using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    public TextMeshProUGUI speed;
    public TextMeshProUGUI time;

    public PlayerMovement pm;
    public GameManager gm;


    private void Update()
    {
        speed.text = "Speed: " + (Mathf.Round(pm.rb.velocity.magnitude * 100f) *0.01f).ToString();
        time.text = ((int)gm.time).ToString() + "s";
    }
}
