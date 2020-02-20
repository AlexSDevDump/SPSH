using UnityEngine;

public class GoalSettings : MonoBehaviour
{
    [SerializeField]
    private int ID;

    public int ReturnID() => ID;
}
