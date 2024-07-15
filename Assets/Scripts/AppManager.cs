using UnityEngine;
public class AppManager : MonoBehaviour
{
    public static AppManager Instance;
    public AppSettings appSettings;
    [SerializeField] GameObject MainPage;
    [Header("Transitions")]
    public Transform CentralPosition;
    
    private void Awake()
    {
        Instance = this;
    }
    public void ChangeLanguage(int language)
    {
        switch (language)
        {
            case 0:
                {
                    appSettings.appLanguage = AppLanguage.English;
                }
                break;
            case 1:
                {
                    appSettings.appLanguage = AppLanguage.Russian;
                }
                break;
            case 2:
                {
                    appSettings.appLanguage = AppLanguage.Espaniol;
                }
                break;
        }
        if (MainPage.activeInHierarchy) 
        {
            MainPage.SetActive(false);
            MainPage.SetActive(true);
        }
    }
}
