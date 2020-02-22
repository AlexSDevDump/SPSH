using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitchController : MonoBehaviour
{
    public int defaultSceneID = 0;
    public Animator anim;
    private int levelToLoad;

    public void NextLevel()
    {
        levelToLoad = (SceneManager.GetActiveScene().buildIndex) + 1;
        anim.SetTrigger("FadeOut");
    }

    public void ToLevel (int levelID)
    {
        levelToLoad = levelID;
        anim.SetTrigger("FadeOut");
    }

    public void LoadLevel()
    {
        if (levelToLoad >= SceneManager.sceneCountInBuildSettings) { levelToLoad = defaultSceneID; }
        SceneManager.LoadScene(levelToLoad);
    }
}
