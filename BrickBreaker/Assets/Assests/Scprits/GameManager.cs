using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float lives;
    public int level;
    public float score;
    private void Awake()
    {
        
    }
    void Start()
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(level);
    }
}
