﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class ButtonExtension
{
	public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener (delegate() {
			OnClick (param);
		});
	}
}

public class FurItemScripts : MonoBehaviour
{
    [Serializable]
	public struct Game
	{
		public string Name;
		public Sprite Icon;
		public GameObject model;
	}

	[SerializeField] Game[] allGames;

	void Start ()
	{
		GameObject buttonTemplate = transform.GetChild (0).gameObject;
		GameObject g;

		int N = allGames.Length;

		for (int i = 0; i < N; i++) {
			g = Instantiate (buttonTemplate, transform);
			g.transform.GetChild (0).GetComponent <Image> ().sprite = allGames [i].Icon;
			g.transform.GetChild (1).GetComponent <Text> ().text = allGames [i].Name;
			g.GetComponent <Button> ().AddEventListener (i, ItemClicked);
		}

		Destroy (buttonTemplate);
	}

	void ItemClicked (int itemIndex)
	{
		Debug.Log ("------------item " + itemIndex + " clicked---------------");
		Debug.Log ("name " + allGames [itemIndex].Name);
        GameControl.control.FurPrefab = allGames [itemIndex].model;
        Debug.Log ($"FurPrefab different null {GameControl.control.FurPrefab != null}");
	}
}
