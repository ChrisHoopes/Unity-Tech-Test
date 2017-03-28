using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	private int _pickupCount = 0;

    public Text GUI_count;

	void Start () {
        GUI_count.text = "0";
    }

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.gameObject.tag == "Switch") {
					if (_pickupCount >= 10) {
						SceneManager.LoadScene("Scene 2");
					}
				}
			}
		}
	}

	public void AddPickup(int pickupValue)
	{
		_pickupCount += pickupValue;
        GUI_count.text = _pickupCount.ToString();
	}
}
