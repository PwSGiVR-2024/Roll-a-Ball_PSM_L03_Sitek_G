using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{

    //UI done
    public TMP_Text scoreText;
    public TMP_Text LVL_Pass;

    //Player done
    private GameObject player;


    //Score
    private int maxScore;
    private int score;


    //Collectible
    public Collectible[] collectibles;

    //Pauza
 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
        
        player = GameObject.Find("Player");
        scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        LVL_Pass = GameObject.Find("Lvlcomp").GetComponent<TMP_Text>();
        collectibles = GameObject.FindObjectsByType<Collectible>(FindObjectsSortMode.None);
        maxScore = collectibles.Length;
        foreach (var item in collectibles)
        {
            item.pickUp += points;
        }
    }

    // Update is called once per frame
    public void points()
    {

        score += 1;
        scoreText.text = "Score: " + score;
        if (score == maxScore)
        {
            LVL_Pass.text = "Przeszedles poziom. Zaraz zostaniesz przeniesiony dalej!!";
            Invoke(nameof(NextLvl), 4.0f);
        }
    }
    public void NextLvl()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
}
