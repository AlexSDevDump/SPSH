using UnityEngine;

public class GoalSettings : MonoBehaviour
{
    [SerializeField]
    private int ID;

    [SerializeField]
    private FillObject fo;


    public int ReturnID() => ID;
    public FillObject ReturnFO() => fo;
}
