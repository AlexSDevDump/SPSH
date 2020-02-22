using UnityEngine;

public class ObjectSettings : MonoBehaviour
{
    public int objectID;
    private Transform goalTransform;
    private FillObject fo;
    [SerializeField]
    private float allowedDistance = 0.5f;
    private float distanceToTarget;
    private GameManager gm;
    public bool threeDim;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        FindTarget();
    }

    void SetToGoal()
    {
        if (fo != null)
        {
            fo.MoveToNextPos(transform);
        }
        else 
        { 
            transform.position = goalTransform.position;
            transform.rotation = goalTransform.rotation;      
        }
    }

    void OnMouseUp()
    {
        distanceToTarget = Vector3.Distance(goalTransform.position, transform.position);
        if (distanceToTarget < allowedDistance) 
        {
            if (threeDim) { GetComponent<BoxCollider>().enabled = false; }
            else if (!threeDim) { GetComponent<PolygonCollider2D>().enabled = false; }
            SetToGoal();
            gm.ObjectPlaced();
        }
    }

    void FindTarget()
    {
        GoalSettings[] gs = FindObjectsOfType<GoalSettings>();
        foreach (GoalSettings g in gs)
        {
            if (g.ReturnID() == objectID)
            { 
                goalTransform = g.transform; 
            }
            if (g.ReturnFO() != null)
            {
                fo = g.ReturnFO();
            }
        }
    }
}
