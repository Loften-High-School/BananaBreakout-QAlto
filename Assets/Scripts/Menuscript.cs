using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour

{
    public void OnSTartClick()
    {
        SceneManager.LoadScene("Main");
    }

     public void OnExitCLick()
     {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
     }
}
