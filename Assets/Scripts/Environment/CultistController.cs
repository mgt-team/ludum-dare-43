using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultistController : MonoBehaviour {

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _fightDistance;

    [SerializeField]
    private float _speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector2.Distance(transform.position, _target.position);
        if (distance > _fightDistance)
            transform.position = Vector2.Lerp(transform.position, _target.position, Time.deltaTime * _speed);
        else
            MakeSacrifice();
	}

    private void MakeSacrifice()
    {

    }
}
