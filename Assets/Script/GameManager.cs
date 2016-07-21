using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static int GAMESTATE_MENU        =0;
    public static int GAMESTATE_PLAYING     =1;
    public static int GAMESTATE_END         =2;
    public static GameManager _ins;

    public Transform firstBg;
    public Text S_Text;
    public int Score;
    public int GameState = GAMESTATE_MENU;

    public GameObject EndMenu;
    private GameObject p_Bird;

    private EndM E_Menu;

    void Awake()
    {
        _ins = this;
        p_Bird = GameObject.FindGameObjectWithTag("Player");
        E_Menu = EndMenu.GetComponent<EndM>();
    }

    void Update()
    {
        if(GameState == GAMESTATE_MENU)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameState = GAMESTATE_PLAYING;
                p_Bird.SendMessage("getActive");
            }
        }

        if(GameState == GAMESTATE_END)
        {
            EndMenu.SetActive(true);
        }

        E_Menu.UpdateScore(Score);

        S_Text.text = "Score: " + Score;

    }
	
}
