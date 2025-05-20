using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HomepageManager : MonoBehaviour
{
    public Button viewProfileButton;
    public Button viewGardenButton;
    public Button roadCameraButton;
    public Button matchWithFriendsButton;
    public Button menuButton;

    void Start()
    {
        viewProfileButton.onClick.AddListener(() => SceneManager.LoadScene("ViewProfile"));
        viewGardenButton.onClick.AddListener(() => SceneManager.LoadScene("ARCameraScene"));
        roadCameraButton.onClick.AddListener(() => SceneManager.LoadScene("RoadCamera"));
        matchWithFriendsButton.onClick.AddListener(() => SceneManager.LoadScene("FriendsList"));
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }
}