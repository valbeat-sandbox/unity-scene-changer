using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    // Scene Controller
    void PlayGame() {
    	Application.LoadLevel("Play");
    }
    void EndGame() {
    }

    // View Controller
    void ShowMain() {
        Application.LoadLevel("Main");
    }
    void ShowScore() {
    	Application.LoadLevel("Score");
    }
    void ShowCredit() {
    	Application.LoadLevel("Credit");
    }

}