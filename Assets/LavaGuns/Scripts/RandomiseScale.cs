using UnityEngine;
using Random = UnityEngine.Random;

namespace LavaGuns.Scripts
{
    public class RandomiseScale : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector2 _range;
        
        private void Start()
        {
            var randomScale = Random.Range(_range.x, _range.y);
            _target.localScale *= randomScale;
        }
    }
}