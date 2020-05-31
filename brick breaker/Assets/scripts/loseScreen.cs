using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("GameOver");
    }
    public void onYesButtounPress()
    {
        SceneManager.LoadScene("Game");
    }
    public void onNOButtounPress()
    {
        Application.Quit();
    }
}
