using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    private int objectsLeftToPlace;
    public GameObject testUI;
    public PlayableDirector cutscene;

    void Start()
    {
        objectsLeftToPlace = FindObjectsOfType<GoalSettings>().Length;
    }

    public void ObjectPlaced()
    {
        objectsLeftToPlace--;
        CheckObjectsLeft();
    }

    public void CheckObjectsLeft()
    {
        if (objectsLeftToPlace <= 0)
        {
            PlayScene();
        }
    }

    public void PlayScene()
    {
        cutscene.Play();
        //testUI.SetActive(true);
    }
}
