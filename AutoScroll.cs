using UnityEngine;

public class AutoScroll : MonoBehaviour {
	
	public RectTransform userText;
	private float scrollSpeed = 1f;
	private Vector3 textPosition;

	private void Update() {
		Debug.Log("textPosition.y : " + userText.anchoredPosition);
	}

	void Awake() {
		userText = GetComponent<RectTransform>();
	}
	public void ScrollText()
	{
		textPosition = userText.anchoredPosition;
		for(float i = 0; i < 100; i ++)
		{
			textPosition.y += scrollSpeed;
		}
	}
}
