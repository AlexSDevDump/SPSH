using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    private int objectsLeftToPlace;
    public bool hasCutscene;
    public PlayableDirector cutscene;
    [SerializeField]
    private LevelSwitchController LSC;

    void Start()
    {
        objectsLeftToPlace = FindObjectsOfType<ObjectSettings>().Length;
        LSC = GetComponentInChildren<LevelSwitchController>();
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
            if (hasCutscene)
            {
                PlayScene();
            }
            else
            {
                LSC.NextLevel();
            }
                
        }
    }

    public void PlayScene()
    {
        cutscene.Play();
    }
}
