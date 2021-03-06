using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalSettings : MonoBehaviour {
	public GameObject[] BlockIDs;
	public static bool pause;
	public static GameObject[] idtable;
	public bool IsLevelDev = false;
	public static bool LevelDev = false;
	public bool[] UsesMetadata;
	public static bool[] UsesMetaData;
    public int MissionLevels;
    public static int Missions;
	// Use this for initialization
	void Awake () {
		LevelDev = IsLevelDev;
		idtable = BlockIDs;
		UsesMetaData = UsesMetadata;
        Missions = MissionLevels;
		//DontDestroyOnLoad(gameObject);
	}
}
