using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    public GameObject startUI;

	public void ToggleUI()
	{
		startUI.SetActive(!startUI.activeSelf);
		
	}

}
