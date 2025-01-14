﻿using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Realtime;

/// <summary>
/// To display room information in the room list.
/// </summary>
public class RoomItemUI : MonoBehaviour {

	[SerializeField] Image TrackIcon;
	[SerializeField] Image RegimeIcon;
	[SerializeField] TextMeshProUGUI HostNickNameText;
	[SerializeField] TextMeshProUGUI SelectedTrackText;
	[SerializeField] TextMeshProUGUI PlayersText;
	[SerializeField] Button OnClickButton;

	public RoomInfo Room { get; private set; }

	public void UpdateInfo (RoomInfo room, Sprite trackIcon, Sprite regimeIcon, string hostNickNameText, string selectedTrackText, string playersText, UnityEngine.Events.UnityAction onClickAction)
	{
		Room = room;
		TrackIcon.sprite = trackIcon;
		RegimeIcon.sprite = regimeIcon;
		HostNickNameText.text = hostNickNameText;
		SelectedTrackText.text = selectedTrackText;
		PlayersText.text = playersText;

		OnClickButton.onClick.RemoveAllListeners ();
		OnClickButton.onClick.AddListener (onClickAction);
	}
}
