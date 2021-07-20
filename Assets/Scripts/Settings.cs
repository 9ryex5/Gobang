using UnityEngine;

public class Settings : MonoBehaviour
{
    public static Settings S;

    public int boardSize;
    public int lineSizeWin;

    public Color colorCell1, colorCell2;
    public Color colorPlayer1, colorPlayer2;

    private void Awake()
    {
        S = this;
    }
}
