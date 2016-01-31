using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counts : MonoBehaviour {
	public Text countText;
	public Text winText;
	public Text timeText;
	public int count;
	public float seconds, minutes, currSec, currMin;
	// Use this for initialization
	void Start () {

		count = 0;

		winText.text = "";

		timeText.text = "02:00";
	

		SetCountText ();

	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count > 14)
		{
			winText.text = "You Win!";
		}

		if (minutes >= 2 && count <= 14) {
			winText.text = "Game Over";
		}
	}
	// Update is called once per frame
	void Update () {
		SetCountText ();
		if (minutes <= 1) {
			minutes = (int)(Time.time / 60f);
			seconds = (int)(Time.time % 60f);
			currSec = 60 - seconds;
			currMin = 1 - minutes;
			timeText.text = currMin.ToString ("00") + ":" + currSec.ToString ("00");
		}
	}
}
