using UnityEngine;

public class AddToParent : MonoBehaviour
{
    public Transform parent;
    public void Func_AddToParent() => transform.SetParent(parent, true);
}
