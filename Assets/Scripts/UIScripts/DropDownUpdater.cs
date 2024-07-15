using TMPro;
using UnityEngine;

public class DropDownUpdater : MonoBehaviour
{
    TMP_Dropdown dropdown;
    private void Awake() {
        dropdown = GetComponent<TMP_Dropdown>();
    }
    private void OnEnable() {
        switch (AppManager.Instance.appSettings.appLanguage)
        {
            case AppLanguage.English:
                {
                    dropdown.value = 1;
                }
                break;
                case AppLanguage.Russian:
                {
                    dropdown.value = 0;
                }
                break;
                case AppLanguage.Espaniol:
                {
                    dropdown.value = 2;
                }
                break;
        }
    }
}
