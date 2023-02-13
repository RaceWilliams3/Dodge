using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : Kinematic
{
    private Face myRotateType;
    private Wander myMoveType;

    public float fireRate;
    private float nextFire = 0f;

    public GameObject bullet;

    void Start()
    {
        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;

        myMoveType = new Wander();
        myMoveType.character = this;
        myMoveType.characterTrans = GetComponent<Transform>();
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();

        steeringUpdate.angular = myRotateType.getSteering().angular;
        steeringUpdate.linear = myMoveType.getSteering().linear;

        base.Update();

        if (Time.time > nextFire && Time.time > 1)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, new Vector3(transform.position.x, 1.5f, transform.position.z), transform.rotation);
        }
    }
}
