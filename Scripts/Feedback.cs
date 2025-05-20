using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FeedbackManager : MonoBehaviour
{
    public Button submitButton;
    public Button menuButton;
    public TMP_InputField feedbackInputField;
    public TMP_InputField suggestionInputField;

    void Start()
    {
        submitButton.onClick.AddListener(SubmitFeedback);
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }

    void SubmitFeedback()
    {
        // Placeholder for feedback submission logic
        string feedback = feedbackInputField.text;
        string suggestion = suggestionInputField.text;
        Debug.Log("Feedback: " + feedback);
        Debug.Log("Suggestion: " + suggestion);

        // Clear the input fields after submission
        feedbackInputField.text = string.Empty;
        suggestionInputField.text = string.Empty;

        // Optionally, you can show a confirmation message to the user
        // For now, just log it
        Debug.Log("Feedback submitted successfully!");

        //load resources scene
        SceneManager.LoadScene("Resources");
    }
}