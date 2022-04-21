using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]

public class BladeExtension : XRGrabInteractable
{
    [SerializeField] Animator bladeAnim;
    [SerializeField] AudioClip bladeExtensionSound;

    AudioSource audioSource;
    bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        activated.AddListener(ToggleBlade);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToggleBlade(ActivateEventArgs args)
    {
        isEnabled = !isEnabled;
        bladeAnim.SetBool("IsTrigger", isEnabled);
        
        audioSource.PlayOneShot(bladeExtensionSound);
    }
}