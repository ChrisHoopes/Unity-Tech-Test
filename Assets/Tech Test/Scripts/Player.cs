using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	private int _pickupCount = 0;

	void Start () {
	
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.gameObject.tag == "Switch") {
					if (_pickupCount >= 5) {
						SceneManager.LoadScene("Scene2");
					}
				}
			}
		}
	}

	public void AddPickup()
	{
		_pickupCount++;
	}
}
