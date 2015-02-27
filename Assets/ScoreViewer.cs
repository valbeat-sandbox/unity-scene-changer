using UnityEngine;
using System.Collections;

public class ScoreViewer : MonoBehaviour {
	private string RANKING_PREF_KEY = "ranking";
	private int RANKING_NUM = 5
	private float[] ranking = new float [RANKING_NUM];

	function getRanking() {
		string score = PlayerPrefs.GetString(RANKING_PREF_KEY);
		if (socre.length > 0) {
			string[] _score = ranking.Split(","[0]);
			ranking = new float[RANKING_NUM];
			for (int i = 0; i < _score.length && i < RANKING_NUM; i++) {
				ranking[i] = parseFloat(score[i]);
			}
		}
	}

	function screenRanking() {
		if (ranking.length > 0) {
			for (int i = 0; i < ranking.length; i++) {
			}
		}
	}
}