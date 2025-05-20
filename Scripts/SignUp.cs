using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SignUpManager : MonoBehaviour
{
    public TMP_InputField NameInput;
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TMP_InputField confirmPasswordInput;
    public Button continueButton;
    public Button backButton;

    void Start()
    {
        continueButton.onClick.AddListener(OnSignUp);
        backButton.onClick.AddListener(OnBack);
    }


    void OnSignUp()
    {
        string name = NameInput.text;
        string email = emailInput.text;
        string password = passwordInput.text;
        string confirmPassword = confirmPasswordInput.text;

        // Save temporarily (for demo)
        PlayerPrefs.SetString("userName", name);
        PlayerPrefs.SetString("userEmail", email);
        PlayerPrefs.SetString("userPassword", password);
        PlayerPrefs.SetString("userConfirmPassword", confirmPassword);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Homepage");
    }

    void OnBack()
    {
        SceneManager.LoadScene("ValidateCredentials");
    }
}
