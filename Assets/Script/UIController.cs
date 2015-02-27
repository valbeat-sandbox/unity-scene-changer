using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
	public GameObject poseMenu = null;
	public GameObject exitConfilmMenu = null;
	public GameObject restartConfilmMenu = null;

	void ShowPoseMenu () {
		poseMenu.SetActive(true);
	}
	void HidePoseMenu () {
		poseMenu.SetActive(false);
	}

	void ShowExitConfilmMenu () {
		exitConfilmMenu.SetActive(true);
	}
	void HideExitConfilmMenu () {
		exitConfilmMenu.SetActive(false);
	}

	void ShowRestartConfilmMenu () {
		restartConfilmMenu.SetActive(true);
	}
	void HideRestartConfilmMenu () {
		restartConfilmMenu.SetActive(false);
	}
}
