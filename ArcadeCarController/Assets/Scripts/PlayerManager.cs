using System.Collections.Generic;
using UnityEngine;

public enum GameMode { Clients = 0, Spectators = 1 };

public class PlayerManager : MonoBehaviour
{
	public static PlayerManager Manager { get; private set; } = null;

	public GameMode gameMode = GameMode.Clients;

	public List<GameObject> instantiatedCars = new List<GameObject>();

	void Awake()
	{
		if (Manager != null && Manager != this)
		{
			Destroy(gameObject);
			return;
		}
		else
		{
			Manager = this;
		}

		DontDestroyOnLoad(gameObject);

		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
}
