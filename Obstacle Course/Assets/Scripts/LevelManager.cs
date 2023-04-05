using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public GameObject TitlePanel;
    public GameObject WinnerPanel;
    public GameObject GameOverPanel;

     public TextMeshProUGUI HealthCountText;

     [SerializeField] private int _playerHealth = 5;
     [SerializeField] private bool _isGameActive = false;

     void Awake()
     {
         Instance = this;
     }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        HealthCountText.text = _playerHealth.ToString();
    }

    public bool StartGame()
    {
        return _isGameActive;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplayButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayButtonPressed()
    {
        Time.timeScale = 1;
        TitlePanel.SetActive(false);
        _isGameActive = true;
    }

    public void UpdatePlayerHealthCount(int amount)
    {
        _playerHealth -= amount;
        HealthCountText.text = _playerHealth.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
        GameManager.Instance.SetHealthCount(_playerHealth);
    }

    public void Winner()
    {
        Time.timeScale = 0;
        WinnerPanel.SetActive(true);
    }
}