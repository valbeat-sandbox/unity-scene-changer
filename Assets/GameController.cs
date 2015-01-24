using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    void GameStart() {
        Application.LoadLevel("Main");
    }
    void PlayGame() {
    	Application.LoadLevel("Play");
    }
    void ShowScore() {
    	Application.LoadLevel("Score");
    }
    void ShowCredit() {
    	Application.LoadLevel("Credit");
    }
}