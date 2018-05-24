using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

    public void GameStart() {
        SceneManager.LoadScene("SlidingTilePuzzle");
    }

    public void GameEnd() {
        SceneManager.LoadScene("StartScene");
    }
}
