using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elementdis : MonoBehaviour
{
    public GameObject FireMenuHolder;
    public GameObject WaterMenuHolder;
    public GameObject WindMenuHolder;
    public GameObject EarthMenuHolder;

    public void FireDis()
    {
        FireMenuHolder.SetActive(true);
        WaterMenuHolder.SetActive(false);
        WindMenuHolder.SetActive(false);
        EarthMenuHolder.SetActive(false);
    }
    public void FireX()
    {
        FireMenuHolder.SetActive(false);
    }
    public void WaterDis()
    {
        FireMenuHolder.SetActive(false);
        WaterMenuHolder.SetActive(true);
        WindMenuHolder.SetActive(false);
        EarthMenuHolder.SetActive(false);
    }
    public void WaterX()
    {
        WaterMenuHolder.SetActive(false);
    }
    public void WindDis()
    {
        FireMenuHolder.SetActive(false);
        WaterMenuHolder.SetActive(false);
        WindMenuHolder.SetActive(true);
        EarthMenuHolder.SetActive(false);
    }
    public void WindX()
    {
        WindMenuHolder.SetActive(false);
    }
    public void EarthDis()
    {
        FireMenuHolder.SetActive(false);
        WaterMenuHolder.SetActive(false);
        WindMenuHolder.SetActive(false);
        EarthMenuHolder.SetActive(true);
    }
    public void EarthX()
    {
        EarthMenuHolder.SetActive(false);
    }
}
