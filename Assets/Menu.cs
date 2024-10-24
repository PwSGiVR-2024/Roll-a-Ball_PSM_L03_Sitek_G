using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("LVL1", LoadSceneMode.Single);
    }

    // Update is called once per frame
    public GameObject OptionsPanel;
    public void Options(bool isActive)
    {
        OptionsPanel.SetActive(isActive);   
    }
    public void OptionsExit(bool isActive)
    {
        OptionsPanel.SetActive(isActive);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
