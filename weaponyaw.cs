using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class weaponyaw : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    [SerializeField] private Quaternion xaxis;
    [SerializeField] private Quaternion yaxis;
    [SerializeField] private float t1;
    [SerializeField] private float t2;
    [SerializeField] private float swayx;
    [SerializeField] private float swayy;
    
    private float mousex;
    private float mousey;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //getting mouse numbers
        mousex = Input.GetAxisRaw("Mouse X");
        mousey = Input.GetAxisRaw("Mouse Y");
        
                                             //sway mechanism
        xaxis = Quaternion.AngleAxis(mousex*swayx,Vector3.up);
        yaxis = Quaternion.AngleAxis(mousey*swayy,Vector3.left);
        //sway x
        weapon.transform.localRotation = Quaternion.Lerp(weapon.transform.localRotation, xaxis, t1);
        //sway y
        weapon.transform.localRotation = Quaternion.Lerp(weapon.transform.localRotation, yaxis, t1);
        //return to position
        weapon.transform.localRotation = Quaternion.Lerp(weapon.transform.localRotation, Quaternion.identity, t2);
    }
}
