using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourcesManager : MonoBehaviour
{
    public Button feedbackButton;
    public Button supportButton;
    public Button menuButton;
    void Start()
    {
        feedbackButton.onClick.AddListener(() => SceneManager.LoadScene("Feedback"));
        supportButton.onClick.AddListener(() => SceneManager.LoadScene("Support"));
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }
}