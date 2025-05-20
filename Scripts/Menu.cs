using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button homepageButton;
    public Button resourcesButton;
    public Button accountButton;

    void Start()
    {
        homepageButton.onClick.AddListener(() => SceneManager.LoadScene("Homepage"));
        accountButton.onClick.AddListener(() => SceneManager.LoadScene("AccountDetails"));
        resourcesButton.onClick.AddListener(() => SceneManager.LoadScene("Resources"));
    }
}
