using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{

    public GameObject StartPanel;
    public GameObject MainPanel;

    // Start is called before the first frame update
    void Start()
    {
        StartPanel.SetActive(true);
        MainPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartClicked()
    {
        SceneManager.LoadScene("MainPanel");
        StartPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void ExitClicked()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
