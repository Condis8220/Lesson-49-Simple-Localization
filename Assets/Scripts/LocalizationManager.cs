using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LocalizationManager : MonoBehaviour
{
    public enum EnLanguage
    {
        RU,
        EN
    }

    [SerializeField]
    private EnLanguage laguage;

    [Space]
    public Button selectRu;
    public Button selectEn;

    public class EnLanguageEvent : UnityEvent<EnLanguage> { }

    public static EnLanguageEvent ChangeLanguage { get; set; } = new EnLanguageEvent();

    private static LocalizationManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        selectRu.onClick.AddListener(() => SelectLanguage(EnLanguage.RU));
        selectEn.onClick.AddListener(() => SelectLanguage(EnLanguage.EN));
    }

    private void SelectLanguage(EnLanguage _language)
    {
        laguage = _language;
        ChangeLanguage.Invoke(laguage);
    }

    public static EnLanguage GetLanguage()
    {
        return instance.laguage;
    }
}
