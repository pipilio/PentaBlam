using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class KeyBoardKeyPressHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public string noteName;

	#region IPointerDownHandler implementation
	public void OnPointerDown (PointerEventData eventData)
	{
		AudioManager.instance.Play(noteName);
		//NotePositioner.instance.ShowNote (noteName);
		GameManager.instance.OnNotePressed (noteName);
	}
	#endregion

	#region IPointerUpHandler implementation
	public void OnPointerUp (PointerEventData eventData)
	{
		AudioManager.instance.CancelPlay (noteName);
	}
	#endregion
}
