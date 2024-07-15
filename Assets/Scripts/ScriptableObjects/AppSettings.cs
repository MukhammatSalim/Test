using UnityEngine;

[CreateAssetMenu(fileName = "AppSettings", menuName = "AppSettings", order = 0)]
public class AppSettings : ScriptableObject 
{
    [Header("Properties")]
    public AppLanguage appLanguage;
}

public enum AppLanguage
{
    English,
    Russian,
    Espaniol
}
