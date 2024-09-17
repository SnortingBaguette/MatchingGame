using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    public bool draggable;
    private Camera cameraObj;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;

    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();




        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }
    private void OnMouseUp()
    {
        if (draggable)
        {
            draggable = false;
            endDragEvent.Invoke();
        }
    }

    public void DisableDraggingOnDeath()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
