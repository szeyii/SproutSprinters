using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AccountDetailsManager : MonoBehaviour
{
    public Button changePasswordButton;
    public Button editAccInfoButton;
    public Button unsubscribeButton;
    public Button logoutButton;
    public Button menuButton;

    void Start()
    {
        // Placeholder listeners for buttons
        changePasswordButton.onClick.AddListener(() => Debug.Log("Change Password clicked"));
        editAccInfoButton.onClick.AddListener(() => Debug.Log("Edit Account Info clicked"));    
        unsubscribeButton.onClick.AddListener(() => Debug.Log("Unsubscribe clicked"));

        logoutButton.onClick.AddListener(() => SceneManager.LoadScene("main"));
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }
}