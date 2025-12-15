using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }


    public void Gallery()
    {
        SceneManager.LoadScene("Gallery");
    }


    public void LoadTitle()
    {
        SceneManager.LoadScene("title");
    }


    public void Quit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}




