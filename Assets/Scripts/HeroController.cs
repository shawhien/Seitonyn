using UnityEngine;

public class HeroController : MonoBehaviour {

    private void Update() {
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
            //Reference for MoveTo in Mover.cs so HeroController knows what it is
            GetComponent<Mover>().MoveTo(hit.point);
        }
    }
}