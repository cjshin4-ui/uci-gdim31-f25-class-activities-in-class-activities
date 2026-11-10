using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] public int speed = 5;
    [SerializeField] public Transform _batTransform;

    public void chase(Transform target)
    {
        speed = 5;
        _batTransform.position = Vector2.MoveTowards(_batTransform.position, target.position, speed * Time.deltaTime);
    }

    public void stopchase()
    {
        speed = 0;
    }
}