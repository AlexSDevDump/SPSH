using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int objectsLeftToPlace;
    public GameObject testUI;

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
        testUI.SetActive(true);
    }
}
