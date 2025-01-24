using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{

    public void StartGame()
    {
        SceneManager.LoadSceneAsync("LVL1", LoadSceneMode.Single);
        
        }
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
