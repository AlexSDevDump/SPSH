using UnityEngine;

public class TranslateObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mzCoord;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        mzCoord = cam.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        PositionDrag();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mzCoord;
        return cam.ScreenToWorldPoint(mousePos);
    }

    private void PositionDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }    
}