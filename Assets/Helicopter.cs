using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private bool isCalledHelicopter;
    AudioSource audiohelicopter;
    public AudioClip sound;
    Rigidbody rb;
    public Vector3 helicopterPosition;
    public static Helicopter instance;
    public bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audiohelicopter = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Helicopter")&&!isCalledHelicopter)
        {
            rb.isKinematic = false;
            isCalledHelicopter = true;
            audiohelicopter.clip = sound;
            audiohelicopter.Play();
            print("Called");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            isgrounded = true;
            audiohelicopter.loop = false;
            helicopterPosition = this.transform.position;
        }
    }
    
}
