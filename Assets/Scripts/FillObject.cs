using UnityEngine;

public class FillObject : MonoBehaviour
{
    public Transform[] fillPositions;
    public int fillIndex;

    public Transform GetNextTransform()
    {
        return fillPositions[fillIndex];
    }

    public void MoveToNextPos(Transform t)
    {
        t.position = GetNextTransform().position;
        t.rotation = GetNextTransform().rotation;
        t.SetParent(GetNextTransform());
        fillIndex++;
    }
}
