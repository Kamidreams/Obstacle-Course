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

     [SerializeField] private int _playerHealth = 0;

    // Start is called before the first frame update
    void Start()
    {
        HealthCountText.text = _playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonPressed()
    {
        Time.timeScale = 1;
        TitlePanel.SetActive(false);
    }

    public void UpdatePlayerHealthCount(int amount)
    {
        _playerHealth -= amount;
        HealthCountText.text = _playerHealth.ToString();
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        GameManager.Instance.SetHealthCount(_playerHealth);
    }

    public void Winner()
    {
        WinnerPanel.SetActive(true);
    }
}