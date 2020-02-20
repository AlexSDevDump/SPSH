using UnityEngine;

public class ObjectSettings : MonoBehaviour
{
    public int objectID;
    private Transform goalTransform;
    [SerializeField]
    private float allowedDistance = 0.5f;
    private float distanceToTarget;
    private GameManager gm;
    public bool threeDim;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        GoalSettings[] gs = FindObjectsOfType<GoalSettings>();
        foreach (GoalSettings g in gs)
        {
            if (g.ReturnID() == objectID) { goalTransform = g.GetComponent<Transform>(); }
        }
    }

    void SetToGoal()
    {
        transform.position = goalTransform.position;
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
}
