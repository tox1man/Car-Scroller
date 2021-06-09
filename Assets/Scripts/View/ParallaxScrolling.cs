using UnityEngine;

namespace Game.Parallax
{
    public class ParallaxScrolling : MonoBehaviour
    {
        [SerializeField]
        private float _leftScreenBorder;
        [SerializeField]
        private float _rightScreenBorder;

        [SerializeField]
        private float _relativeSpeed;

        private void MoveBackground(float value)
        {
            transform.position += Vector3.right * value * _relativeSpeed;
            Vector3 position = transform.position;
            if (position.x <= _leftScreenBorder)
                transform.position = new Vector3(_rightScreenBorder - (_leftScreenBorder - position.x), position.y, position.z);
           else if (transform.position.x >= _rightScreenBorder)
                transform.position = new Vector3(_leftScreenBorder + (_rightScreenBorder - position.x), position.y, position.z);

        }
    }
}
