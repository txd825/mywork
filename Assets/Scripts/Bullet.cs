using UnityEngine;

/// <summary>
/// 子弹
/// </summary>
public class Bullet : MonoBehaviour
{
    public GameObject EffectTemplate;

    public AudioClip SoundEffect;
    void OnCollisionEnter(Collision collision)
    {
        print("Hit!");

        GameObject go = Instantiate(EffectTemplate);
        go.transform.position = transform.position;
        Destroy(go, 5);
        AudioSource.PlayClipAtPoint(SoundEffect, transform.position);
        Destroy(gameObject);
    }
}