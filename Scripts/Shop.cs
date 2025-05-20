using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public Button menuButton;
    public Button redeemButton1;
    public Button redeemButton2;
    public Button redeemButton3;
    public Button redeemButton4;
    public Button redeemButton5;
    public Button redeemButton6;
    public GameObject notificationPopup;

    void Start()
    {
        redeemButton1.onClick.AddListener(ShowNotification);
        redeemButton2.onClick.AddListener(ShowNotification);
        redeemButton3.onClick.AddListener(ShowNotification);
        redeemButton4.onClick.AddListener(ShowNotification);
        redeemButton5.onClick.AddListener(ShowNotification);
        redeemButton6.onClick.AddListener(ShowNotification);

        menuButton.onClick.AddListener(() => SceneManager.LoadScene("RoadCamera"));

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
