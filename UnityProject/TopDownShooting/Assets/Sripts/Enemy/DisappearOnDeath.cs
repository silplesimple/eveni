using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnDeath : MonoBehaviour
{
    private HealthSystem healthSystem;
    private Rigidbody2D rigidbody;
    private SpriteRenderer[] sprites;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        rigidbody = GetComponent<Rigidbody2D>();
        healthSystem.OnDeath += OnDeath;
        sprites = GetComponentsInChildren<SpriteRenderer>();
    }

    void OnDeath()
    {
        Debug.Log("ав╬З╢ы");
        rigidbody.velocity = Vector3.zero;

        foreach(SpriteRenderer renderer in sprites)
        {
            Color color = renderer.color;
            color.a = 0.3f;
            renderer.color = color;
        }
        transform.gameObject.SetActive(false);

        Destroy(gameObject,2f);      
        
    }
}
