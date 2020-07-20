
using UnityEngine;
//Referencia_tirado de: /*https://www.youtube.com/watch?v=MFQhpwc6cKE */
public class CameraFolllow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
