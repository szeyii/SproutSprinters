using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("ValidateCredentials");
    }
}
