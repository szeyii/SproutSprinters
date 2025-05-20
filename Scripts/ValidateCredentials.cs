using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public Button loginButton;
    public Button signUpButton;
    //public Text errorText;

    // Dummy user data for demonstration
    private string storedUsername = "user";
    private string storedPassword = "password";

    void Start()
    {        
        loginButton.onClick.AddListener(OnLogin);
        signUpButton.onClick.AddListener(OnSignUp);
        //errorText.text = "";
    }

    void OnLogin()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (username == storedUsername && password == storedPassword)
        {
            // Login successful
            //errorText.text = "Login Successful!";
            //errorText.color = Color.green;

            // Load the ARCameraScene after successful login
            SceneManager.LoadScene("Homepage");
        }
        else
        {
            // Login failed
            //errorText.text = "Invalid Username or Password";
            //errorText.color = Color.red;
        }
    }

    void OnSignUp()
    {
        // Load the SignUp scene
        SceneManager.LoadScene("SignUp");
    }
}