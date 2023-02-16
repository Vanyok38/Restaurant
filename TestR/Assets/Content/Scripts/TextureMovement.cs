using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMovement : MonoBehaviour
{
    public float speed = 1.0f;

    private Renderer renderer;
    private Vector2 textureOffset;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        textureOffset = Vector2.zero;
    }

    private void Update()
    {
        textureOffset.y += speed * Time.deltaTime;
        renderer.material.mainTextureOffset = textureOffset;
    }
}