using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
using VNCreator;

public class MrnuManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private TMP_InputField characterName;
    private string name;
    // Start is called before the first frame update

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<GameManager>();
    }

    public void OnEnterClick()
    {
        name = characterName.text;
        gameManager.PlayerName(name);
        SceneManager.LoadScene(2);
    }

}
