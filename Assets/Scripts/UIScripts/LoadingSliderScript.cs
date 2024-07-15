using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class LoadingSliderScript : MonoBehaviour
{
    [SerializeField] Slider loadingSlider;
    public TMP_Text text;
    private void Awake() {
         loadingSlider = GetComponent<Slider>();
    }
    private void Start()
    {
       
    }
    public void LauchDownload(float sec)
    {

        gameObject.SetActive(true);
        StartCoroutine(LoadingAnimation(sec));
    }
    IEnumerator LoadingAnimation(float TotalSec)
    {
        CleanupInstallation();
        float currentTime = 0;
        float timeInterval = TotalSec / 100;
        byte Percent = 0;
        while (currentTime < TotalSec)
        {
            currentTime += timeInterval;
            loadingSlider.value = Percent;
            text.text = Percent + "%";
            Percent += 1;

            yield return new WaitForSeconds(timeInterval);
        }
    }
    public void CleanupInstallation()
    {
        loadingSlider.value = 0;
        text.text = 0 + "%";
    }
}
