﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithLongBarrel : RifleDecorator
{

    public int m_Accuracy = 10;
    public string prefabPath = "Rifle With Long Barrel";
    public GameObject model;

    public WithLongBarrel(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_Accuracy;
    }

    public override float GetAmmoCount()
    {
        return base.GetAmmoCount();
    }
}
