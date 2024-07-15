using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextLocalization : MonoBehaviour
{
    TMP_Text text;
    public string RusText;
    public string EngText;
    public string EspText;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void OnEnable()
    {
        switch (AppManager.Instance.appSettings.appLanguage)
        {
            case AppLanguage.English:
                {
                    text.text = EngText;
                }
                break;
                case AppLanguage.Russian:
                {
                    text.text = RusText;
                }
                break;
                case AppLanguage.Espaniol:
                {
                    text.text = EspText;
                }
                break;
        }
    }
}
