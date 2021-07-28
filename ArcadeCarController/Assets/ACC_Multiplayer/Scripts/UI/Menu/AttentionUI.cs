using UnityEngine;

/// <summary>
/// To attention users about not the full version.
/// </summary>
public class AttentionUI :MonoBehaviour
{
	[SerializeField] AudioClip ClickClip;
	[SerializeField] string NextSceneName = "MainMenuScene";
	[SerializeField] GameObject PCTextObject;
	[SerializeField] GameObject MobileTextObject;

	void Awake ()
	{
		PCTextObject.SetActive (!Application.isMobilePlatform);
		MobileTextObject.SetActive (Application.isMobilePlatform);
	}

	//void Update ()
	//{
	//	if (Input.touchCount > 0 || Input.anyKey)
	//	{
	//		Destroy (this);
	//		SoundControllerInUI.PlayAudioClip (ClickClip);
	//		LoadingScreenUI.LoadScene (NextSceneName);
	//	}
	//}

	public void ClientClick()
    {
		PlayerManager.Manager.gameMode = GameMode.Clients;
		Destroy(this);
		SoundControllerInUI.PlayAudioClip(ClickClip);
		LoadingScreenUI.LoadScene(NextSceneName);
	}

	public void SpectatorClick()
	{
		PlayerManager.Manager.gameMode = GameMode.Spectators;
		Destroy(this);
		SoundControllerInUI.PlayAudioClip(ClickClip);
		LoadingScreenUI.LoadScene(NextSceneName);
	}
}
