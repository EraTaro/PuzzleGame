using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

    public void P3by3Start() {
        SceneManager.LoadScene("3by3Puzzle");
    }

    public void P4by4Start()
    {
        SceneManager.LoadScene("4by4Puzzle");
    }

    public void P5by5Start()
    {
        SceneManager.LoadScene("5by5Puzzle");
    }

    public void RankingStart()
    {
        SceneManager.LoadScene("RankingScene");
    }

    public void GameEnd() {
        SceneManager.LoadScene("StartScene");
    }
}
