using System;
using UnityEngine;

namespace LavaGuns.Scripts
{
    public class ScrollTexture : MonoBehaviour
    {
        [SerializeField] private Renderer _renderer;
        [SerializeField] private Vector2 _speed;

        private void Update()
        {
            _renderer.sharedMaterial.mainTextureOffset += _speed * Time.deltaTime;
        }

        private void OnDestroy()
        {
            _renderer.sharedMaterial.mainTextureOffset = Vector2.zero;
        }
    }
}
