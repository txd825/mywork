using UnityEngine;

/// <summary>
/// 车载武器
/// </summary>
public class Turret : MonoBehaviour
{
    public Transform MouseLookTra;
    public Transform FollowLookTra;
    public GameObject BulletTemplate;
    public Transform LaunchPoint;

    void Update()
    {
        FollowLookTra.localRotation = MouseLookTra.localRotation;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    void Fire()
    {
        var go = Instantiate(BulletTemplate);
        go.transform.position = LaunchPoint.position;
        go.transform.rotation = LaunchPoint.rotation;
        go.GetComponent<Rigidbody>().velocity = LaunchPoint.forward*100;
    }
}