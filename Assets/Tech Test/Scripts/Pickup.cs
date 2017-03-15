using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	private AudioSource _pickupSound;
	private bool _collected = false;

	[SerializeField]
	private GameObject _mesh;

	void Start () {
		_pickupSound = GetComponent<AudioSource>();
	}

	void Update () {
	
	}

	private void OnTriggerEnter(Collider other)
	{
		OnTrigger(other);
	}

	private void OnTriggerStay(Collider other)
	{
		OnTrigger(other);
	}

	private void OnTrigger(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			PlayerPickup(other);
		}
	}

	private void PlayerPickup(Collider other)
	{
		if (_collected) {
			return;
		}

		_pickupSound.Play();
		other.GetComponent<Player>().AddPickup();
		_mesh.SetActive(false);
		_collected = true;
	}
}
