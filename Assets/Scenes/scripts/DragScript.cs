using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform trans;
    public Canvas canvas;
    SFXScript sfxScript;

    void Start()
    {
        sfxScript = FindObjectOfType<SFXScript>();
        trans = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Uzklišķināts uz velkama objekta!");
        sfxScript.PlaySFX(0);
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Sākta objekta vilkšana!");
    }

    public void OnDrag(PointerEventData data)
    {
        Debug.Log("Notiek vilkšana!");

        Vector2 mousePosition = data.position;

        // Ierobežojam X un Y robežas ekrānā
        float halfWidth = trans.rect.width / 2;
        float halfHeight = trans.rect.height / 2;

        mousePosition.x = Mathf.Clamp(mousePosition.x, halfWidth, Screen.width - halfWidth);
        mousePosition.y = Mathf.Clamp(mousePosition.y, halfHeight, Screen.height - halfHeight);

        trans.position = mousePosition;
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Beigusies objekta vilkšana!");
    }
}