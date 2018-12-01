using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogToSacrifice : MonoBehaviour {

    [SerializeField]
    private Transform _center;

    [SerializeField]
    private GameObject _dog;

    public DogToSacrifice()
    {
        Instantiate(_dog, _center.position, Quaternion.identity);
    }
}
