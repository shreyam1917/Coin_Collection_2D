using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(0);
    }
    public void Instructions()
    {
        SceneManager.LoadScene(5);
    }
    public void Quit_Game()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_One()
    {
        SceneManager.LoadScene(0);
    }
    public void Level_Two()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_Three()
    {
        SceneManager.LoadScene(2);
    }
    public void Level_Four()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_Five()
    {
        SceneManager.LoadScene(1);
    }
    public void Lone_Info()
    {
        SceneManager.LoadScene(5);
    }
    public void Ltwo_Info()
    {
        SceneManager.LoadScene(6);
    }
    public void Lthree_Info()
    {
        SceneManager.LoadScene(7);
    }
    public void Lfour_Info()
    {
        SceneManager.LoadScene(8);
    }
}
