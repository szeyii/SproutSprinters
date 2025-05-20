using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoadCameraManager : MonoBehaviour
{
    public Button menuButton;
    public Button liveViewButton;
    public Button createButton;
    public Button friendsButton;
    public Button shopButton;

    public Button locationButton1;
    public Button locationButton2;
    public Button locationButton3;

    public GameObject notificationPopup;

    void Start()
    {
   
        liveViewButton.onClick.AddListener(() => Debug.Log("Live View Button Clicked"));
        createButton.onClick.AddListener(() => SceneManager.LoadScene("Posts"));
        friendsButton.onClick.AddListener(() => SceneManager.LoadScene("FriendsList"));
        shopButton.onClick.AddListener(() => SceneManager.LoadScene("Shop"));

        locationButton1.onClick.AddListener(ShowNotification);
        locationButton2.onClick.AddListener(ShowNotification);
        locationButton3.onClick.AddListener(ShowNotification);

        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));

    }

    public void ShowNotification()
    {
        notificationPopup.SetActive(true);
    }

    public void HideNotification()
    {
        notificationPopup.SetActive(false);
    }
}
