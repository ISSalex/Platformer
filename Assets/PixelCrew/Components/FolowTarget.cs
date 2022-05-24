using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew
{
    public class FolowTarget : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _dumping;

        private void LateUpdate()
        {
            var destruction = new Vector3(_target.position.x, _target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, destruction, Time.deltaTime * _dumping);
        }
    }

}