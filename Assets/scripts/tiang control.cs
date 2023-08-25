using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiangcontrol : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public audiomanajer audioManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
	renderer = GetComponent<Renderer>();
	animator = GetComponent<Animator>();

    	renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
    	if(collision.collider == bola)
        {
		Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
		bolaRig.velocity *= multiplier;

		animator.SetTrigger("hit");

		audioManager.PlaySFX(collision.transform.position);
	}
    }
}
