using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Gameplay : MonoBehaviour
{
    [SerializeField] Button playButton;

    void Awake()
    {
        playButton.onClick.AddListener(PlayButtonClicked);
    }

    private void PlayButtonClicked()
    {
        NetworkManager.Instance.StartGame();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
