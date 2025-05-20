using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SupportRequestManager : MonoBehaviour
{
    public Button submitButton;
    public Button menuButton;
    public TMP_InputField problemInputField;
    public TMP_InputField descriptionInputField;

    void Start()
    {
        submitButton.onClick.AddListener(SubmitSupportRequest);
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }

    void SubmitSupportRequest()
    {
       // Placeholder for support request submission logic
        string problem = problemInputField.text;
        string description = descriptionInputField.text;
        Debug.Log("Problem: " + problem);
        Debug.Log("Description: " + description);

        // Clear the input fields after submission
        problemInputField.text = string.Empty;
        descriptionInputField.text = string.Empty;

        // Optionally, you can show a confirmation message to the user
        // For now, just log it
        Debug.Log("Support request submitted successfully!");

        //load resources scene
        SceneManager.LoadScene("Resources");
    }
}