using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public SphereCollider sphere;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(rigidbody.velocity.magnitude.ToString());
        //source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(rigidbody.velocity.magnitude.ToString());
        //source.volume = rigidbody.velocity.magnitude;
        if (Mathf.Abs(rigidbody.velocity.magnitude) > 0.001f)
        {
            source.PlayOneShot(clip);
        }
    }
}
