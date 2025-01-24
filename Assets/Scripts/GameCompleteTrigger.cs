using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCompleteTrigger : MonoBehaviour
{
    public GameObject gameCompleteUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowGameCompleteMessage();
            Invoke(nameof(NextLvl), 4.0f);
        }
    }
    public void NextLvl()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    void ShowGameCompleteMessage()
    {
        if (gameCompleteUI != null)
        {
            gameCompleteUI.SetActive(true);
            
        }
    }
}