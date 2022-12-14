using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonStaticBaseClass 
{
    public enum GameMode
    {
        Playing,
        Finished
    }

    public  GameMode CurrentGameMode = GameMode.Playing;

    public  string GameName = "Test Game";


    // Yapıcı metodumuz.
    //newleyerek yeni bir object oluşturdugumuzda parametlelerde fieldlarımızın değerlerini ayarlayabiliyoruz.
    public NonStaticBaseClass(string name, GameMode newGameMode)
    {
        CurrentGameMode = newGameMode;
        GameName = name;
    }

    public static bool IsGamePlaying()
    {
        return true;
    }
}
