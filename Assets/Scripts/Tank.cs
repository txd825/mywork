using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Tank : MonoBehaviour
{

    public Turret Turret;
    [SerializeField] private MouseLook _mouseLook;

    void Awake()
    {
        _mouseLook.Init(Turret.transform, Turret.MouseLookTra);
    }

	void Update () {

        _mouseLook.LookRotation(Turret.transform, Turret.MouseLookTra);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
}
