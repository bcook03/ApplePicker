using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HighScore : MonoBehaviour{
    static private TextMeshProUGUI _UI_TEXT;
    static private int _SCORE = 1000;

    private TextMeshProUGUI txtCom;

    void Awake() {
        _UI_TEXT = GetComponent<TextMeshProUGUI>();
    }

    static public int SCORE {
        get { return _SCORE;}
        private set {
            _SCORE = value;
            if (_UI_TEXT != null) {
                _UI_TEXT.text = "High Score: " + value.ToString("#,0");
            }
        }
    }

    static public void TRY_SET_HIGH_SCORE(int scoreToTry) {
        if (scoreToTry <= SCORE) return; // If ScoreToTry is too low, return
        SCORE = scoreToTry;
    }

}
