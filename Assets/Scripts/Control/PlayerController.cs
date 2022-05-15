using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update() 
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            MoveToCursor();
        }    
    }

     private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<Mover>().MoveTo(hit.point);
        }
    }
}
