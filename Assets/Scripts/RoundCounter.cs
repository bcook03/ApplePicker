using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;
    
    private TextMeshProUGUI uiText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
        if (uiText == null) {
            Debug.LogError("Text component not found on " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "Round " + round.ToString("#");
    }
}
