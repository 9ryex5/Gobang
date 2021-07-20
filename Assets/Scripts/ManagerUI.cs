using UnityEngine;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour
{
    public static ManagerUI MUI;

    public Text textPlayerTurn;
    public Text textGameResult;
    public GameObject buttonRestart;

    private void Awake()
    {
        MUI = this;
    }

    public void PlayerTurn(bool _player2)
    {

        textPlayerTurn.text = _player2 ? "Player 2 Turn" : "Player 1 Turn";
        textPlayerTurn.color = _player2 ? Settings.S.colorPlayer2 : Settings.S.colorPlayer1;
    }

    public void Restart()
    {
        textPlayerTurn.gameObject.SetActive(true);
        textGameResult.gameObject.SetActive(false);
        buttonRestart.SetActive(false);
    }

    public void Endgame(int _result)
    {
        switch (_result)
        {
            case 0:
                textGameResult.text = "Draw";
                break;
            case 1:
                textGameResult.text = "Player 1 Wins!";
                break;
            case 2:
                textGameResult.text = "Player 2 Wins!";
                break;
        }

        textPlayerTurn.gameObject.SetActive(false);
        textGameResult.gameObject.SetActive(true);
        buttonRestart.SetActive(true);
    }
}
