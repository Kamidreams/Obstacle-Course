using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private int _healthCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealthCount(int amount)
    {
        _healthCount -= amount;
    }

    public int GetHealthCount()
    {
        return _healthCount;
    }
}
