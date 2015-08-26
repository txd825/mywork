using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Gun : MonoBehaviour
{

    public GameObject BulletTemplate;

    public GameObject LaunchPoint;


    public float BulletSpeed;

    void Awake()
    {
        
    }

	// Use this for initialization
    void Start()
    {

	}
	
	// Update is called once per frame
	public void Fire()
    {
	    if (Time.frameCount % 6 == 0)
        {
            GameObject go = Instantiate(BulletTemplate);
            go.transform.position = LaunchPoint.transform.position;
            go.GetComponent<Rigidbody>().velocity = LaunchPoint.transform.forward * BulletSpeed;
            go.transform.up = LaunchPoint.transform.forward;

            GetComponent<AudioSource>().Play();
        }
	}
}
