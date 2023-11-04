using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponaim : MonoBehaviour
{
    [SerializeField] GameObject oldweapon;
    [SerializeField] GameObject weapon;
    [SerializeField] private Vector3 aim;
    [SerializeField] private float t1;
    [SerializeField] private float t2;

    // Start is called before the first frame update
    void Start()
    {
        aim = new Vector3(-4.65f, 1f, -4.5f);
        t1 = 0.002f;
        t2 = 0.06f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            weapon.transform.localPosition = Vector3.Slerp(weapon.transform.localPosition, weapon.transform.localPosition+aim, t1);
        }
        weapon.transform.localPosition = Vector3.Slerp(weapon.transform.localPosition, oldweapon.transform.localPosition, t2);

    }
}
