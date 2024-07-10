using UnityEngine;

[CreateAssetMenu(fileName = "AppSettings", menuName = "AppSettings", order = 0)]
public class AppSettings : ScriptableObject 
{
    [Header("Singleton")]
    static AppSettings _instance;
    public static AppSettings instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<AppSettings>("AppSettings");
            }
            return _instance;
        }
    }
    [Header("Properties")]
    public AppLanguage appLanguage;
}

public enum AppLanguage
{
    English,
    Russian
}
