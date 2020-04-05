using UnityEngine;

public class HeroController : MonoBehaviour 
{

    private void Update()
    {
        //ctrl + . to automatically create function below it
        CombatInteraction();
        MovementInteraction();
    }

    private void CombatInteraction()
    {
        throw new NotImplementedException();
    }

    private void MovementInteraction()
    {
        //Raycast from camera to left mouse-click location
        if (Input.GetMouseButtonDown(1))
        {
            MoveToCursor();
        }
    }

    //implement click to move on left click
    private void MoveToCursor()
    {
        //create variable parameters for Raycast()
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // https://docs.unity3d.com/ScriptReference/RaycastHit.html
        RaycastHit hit;
        //when hasHit is true, store position of raycast in (out) hit.
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            //Be able to Raycast to components, not just terrain
            GetComponent<Mover>().MoveTo(hit.point);
        }
    }
}