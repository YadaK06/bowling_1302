using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void BacktoMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
