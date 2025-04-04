using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu("Scoredplus1")]
    public void scorer()
    {
        playerscore++;
        scoretext.text = playerscore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void towover()
    {
        gameoverscreen.SetActive(true);
    }
}
