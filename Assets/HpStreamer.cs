using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpStreamer : MonoBehaviour {

    [SerializeField]
    private Liveble _player;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = "HP:" + _player.CurrentHp.ToString();
    }
}
