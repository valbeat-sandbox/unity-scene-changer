using UnityEngine;
using System.Collections;

// 画面遷移やゲームのコントロールをする。←分けたほうがいいかも
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