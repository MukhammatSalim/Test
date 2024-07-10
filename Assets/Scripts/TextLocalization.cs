using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextLocalization : MonoBehaviour
{
    TMP_Text text;
    public string RusText;
    public string EngText;

    private void Awake() {
        text = GetComponent<TMP_Text>();
    }
    private void OnEnable() {
        if (AppSettings.instance.appLanguage == AppLanguage.Russian) text.text = RusText;
        else text.text = EngText;
    }
}
