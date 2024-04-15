using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VNCreator;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private VNCreator_DisplayUI displayUi;
    [SerializeField]
    private string playerName;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        int Scene = SceneManager.GetActiveScene().buildIndex;

        if(Scene == 2)
        {
            CharacterName(playerName);
        }
    }    

    public void CharacterName(string newName)
    {
        displayUi = GameObject.FindGameObjectWithTag("VnCreator").GetComponent<VNCreator_DisplayUI>();

        if (displayUi != null) 
        {
            displayUi.UpdatePlayerName(newName);
        }        
    }

    public void PlayerName(string newName) 
    {
        playerName = newName;
    }

    public void OnNext()
    {
        displayUi.MyNextNode();
    }

    public void OnPrevious()
    {
        displayUi.MyPreviousNode();
    }
}
