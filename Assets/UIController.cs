using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
	public GameObject menu = null;

	void ShowMenu () {
		Debug.Log("true");
		menu.SetActive(true);
	}
}
