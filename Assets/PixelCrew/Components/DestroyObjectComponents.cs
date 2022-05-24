using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew
{
    public class DestroyObjectComponents : MonoBehaviour
    {
        [SerializeField] private GameObject _objectToDestroy;
        public void DestroyObject()
        {
            Destroy(_objectToDestroy);
        }
    }
}