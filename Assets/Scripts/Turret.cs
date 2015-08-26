using UnityEngine;

/// <summary>
/// 车载武器
/// </summary>
public class Turret : MonoBehaviour
{
    public Transform MouseLookTra;
    public Transform FollowLookTra;

    public Gun Gun;

    void Update()
    {
        FollowLookTra.localRotation = MouseLookTra.localRotation;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Gun.Fire();
        }
    }

}