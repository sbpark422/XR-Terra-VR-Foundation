using UnityEngine;

public class SetXRotation : MonoBehaviour
{
    public FollowOnRail rail;

    void Update()
    {
        Quaternion newRotation = Quaternion.Euler(rail.valueOut, 0, 0);
        transform.rotation = newRotation;
    }
}
