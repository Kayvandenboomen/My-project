using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Pong2player()
    {
        SceneManager.LoadScene("Pong 2 player");
    }
    public void Pong1player()
    {
        SceneManager.LoadScene("Pong 1 player");
    }
    public void PongMayhemmode()
    {
        SceneManager.LoadScene("Pong Mayhem mode");
    }
    
}