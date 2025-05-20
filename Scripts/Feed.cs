using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FeedManager : MonoBehaviour
{
    public Button menuButton;

    void Start()
    {
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }
}
