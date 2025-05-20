using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ViewProfileManager : MonoBehaviour
{
    public Button backButton;

    void Start()
    {
        backButton.onClick.AddListener(() => SceneManager.LoadScene("Homepage"));
        // main function not really out yet so just leave as like that
    }
}
