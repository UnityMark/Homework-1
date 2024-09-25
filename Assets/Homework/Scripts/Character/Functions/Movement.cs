using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Move(Transform transformObject, float speed, Vector3 direction)
    {
        transformObject.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    public void MovePhysics(Rigidbody rigidbody, float speed, Vector3 direction)
    {
        rigidbody.AddForce(direction * speed, ForceMode.Force);
    }

    public void Rotator(Transform transformObject, float speed, Vector3 direction)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        float step = speed * Time.deltaTime;
        transformObject.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}
