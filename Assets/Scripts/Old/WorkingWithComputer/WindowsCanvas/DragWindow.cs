using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragWindow : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    public float PosX;
    public float PosY;
    public float maxPosX;
    public float minPosX;
    public float maxPosY;
    public float minPosY;

   void Start()
    {
        PosX = transform.localPosition.x;
        PosY = transform.localPosition.y;
    }

    //public void DragHandler(BaseEventData eventData)
    //{
    //    //PointerEventData pointerData = (PointerEventData)data;
    //    //Vector2 position;
    //    //RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);
    //    //transform.position = canvas.transform.TransformPoint(position)
    //    //transform.localPosition += (Vector3)data.delta;
    //    transform.localPosition += (Vector3)eventData.delta / canvas.scaleFactor;
    //}

    public void OnBeginDrag(PointerEventData data)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        //transform.localPosition.x = Mathf.Clamp(transform.localPosition.x, minPosX, maxPosX);
        //transform.localPosition.y = Mathf.Clamp(transform.localPosition.x, minPosY, maxPosY);

        Vector3 pos = transform.localPosition;
        //transform.localPosition = new Vector3(Mathf.Clamp(PosX, minPosX, maxPosX), Mathf.Clamp(PosY, minPosY, maxPosY), transform.position.z);

        //transform.localPosition += (Vector3)eventData.delta / canvas.scaleFactor;

        pos.x = Mathf.Clamp(pos.x, minPosX, maxPosX);
        pos.y = Mathf.Clamp(pos.y, minPosY, maxPosY);

        pos += (Vector3)eventData.delta / canvas.scaleFactor;

        transform.localPosition = pos;
        //Vector2 pos;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
        //transform.localPosition = canvas.transform.TransformPoint(pos);

    }

    public void OnEndDrag(PointerEventData data)
    {

    }
}
