using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostsManager : MonoBehaviour
{
    public Button menuButton;
    public Button postButton;
    public Button insertPhotoButton;

    void Start()
    {
        postButton.onClick.AddListener(() => SceneManager.LoadScene("FriendsList"));
        menuButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));

        //log when insert photo button is clicked
       insertPhotoButton.onClick.AddListener(() => Debug.Log("Insert Photo clicked"));
    }
}
