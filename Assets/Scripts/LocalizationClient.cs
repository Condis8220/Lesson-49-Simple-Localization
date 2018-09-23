using UnityEngine;
using UnityEngine.UI;

public class LocalizationClient : MonoBehaviour
{
    public string ru;
    public string en;

    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();

        SetLanguage(LocalizationManager.GetLanguage());

        LocalizationManager.ChangeLanguage.AddListener(SetLanguage);
    }

    private void SetLanguage(LocalizationManager.EnLanguage _language)
    {
        textComponent.text = _language == LocalizationManager.EnLanguage.RU ? ru : en;
    }
}
