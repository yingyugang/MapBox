using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    Transform mTrans;

    void Awake()
    {
        mTrans = transform;
    }

    void LateUpdate()
    {
        mTrans.position = target.position + offset;
    }
}
