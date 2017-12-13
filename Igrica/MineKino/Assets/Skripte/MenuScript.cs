using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript  {

//	private AssetBundle myLoadedAssetBundle;
//	private string[] scenePaths;

//	void Start()
//	{
//		myLoadedAssetBundle = AssetBundle.LoadFromFile ("Assets/AssetBundles/Scene");
//		scenePaths = myLoadedAssetBundle.GetAllScenePaths ();
//	}

	public void pokreniIgru()
	{
		//Application.LoadLevel ("GameScene");
		SceneManager.LoadScene ("GameScene");
	}
}
