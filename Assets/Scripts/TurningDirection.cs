using UnityEngine;

public class TurningDirection : MonoBehaviour
{
    [SerializeField] bool isTurningRight;
    private float rotationDegree = 0f;
    private void Start()
    {
        if (isTurningRight)
        {
            rotationDegree = 90f;
        }
        else
        {
            rotationDegree = -90f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.Rotate(0f, rotationDegree, 0f, Space.Self);

    }
}
