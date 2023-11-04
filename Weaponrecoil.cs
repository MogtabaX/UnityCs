using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weaponrecoil : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    [SerializeField] private Transform oldweapon;
    [SerializeField] private Vector3 recoil;
    [SerializeField] private Vector3 recoilr;
    [SerializeField] private Transform empty;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Rigidbody box;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddRelativeForce(recoil, ForceMode.Force);
            box.AddRelativeTorque(recoilr, ForceMode.Impulse);

        }
        empty.transform.rotation = Quaternion.Lerp(empty.transform.rotation,quaternion.identity,0.04f);
    }
}