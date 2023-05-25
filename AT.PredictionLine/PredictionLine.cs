using System;
using System.IO;
using BepInEx;
using UnityEngine;

namespace PredictionLine
{
    [BepInPlugin("AT.PredictionLine", "AT.榴弹预测线PredictionLine", "1.0.0")]
    public class MyFirstBepInExMod : BaseUnityPlugin
    {
    }
    public class yucexian : MonoBehaviour
    {
        public Vector3[] jigedian = new Vector3[60];
        public Transform yuandian;
        public float paowa = 76;
        public float changdu = 0.2f;
        private Vector3 house;

        private void Awake()
        {


        }


        void Start()
        {

        }

        private void Update()
        {
            house.x = 0;
            house.y = -9.81f;
            house.z = 0;
            for (int fFor = 0; fFor < jigedian.Length; fFor++)
            {
                jigedian[fFor] = yuandian.position + yuandian.forward * paowa * fFor * changdu
                  + house * (0.5f * (fFor * changdu) * (fFor * changdu));
            }
            this.GetComponent<LineRenderer>().positionCount = jigedian.Length;
            this.GetComponent<LineRenderer>().SetPositions(jigedian);
            this.GetComponent<LineRenderer>().enabled = true;
        }
    }
}
