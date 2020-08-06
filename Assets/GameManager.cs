using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameEnded = false;
    public Spawner spawnPoint;
    public Rotator rotator;
    public Animator animator;

    public void EndGame()
    {
        if (isGameEnded == false)
        {
            animator.SetTrigger("EndGame");
            isGameEnded = true;
            spawnPoint.enabled = false;
            rotator.enabled = false;
            return;
        }
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
