using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VoxelStyleParticlesEffects
{
    public class Demo : MonoBehaviour
    {
        public Button Next;
        public Button Switch;
        public Text Name;
        public Transform effects;
        public Transform Light;
        public Transform camA, camB, camC;
        public Transform lightA, lightB;
        int id;
        // Start is called before the first frame update
        void Start()
        {
            //InvokeRepeating("ButtonNextOnClick", 10f, 10f);
            //InvokeRepeating("ButtonLightOnClick", 5f, 5f);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void ButtonNextOnClick()
        {
            foreach (Transform item in effects)
            {
                item.gameObject.SetActive(false);
            }
            int childCount = effects.childCount;
            if(id+1 < childCount)
            {
                id++;
            }
            else
            {
                id = 0;
            }
            if(id <= 9)
            {
                Camera.main.transform.parent = camA;
            }
            else if(id <= 14)
            {
                Camera.main.transform.parent = camB;
            }
            else
            {
                Camera.main.transform.parent = camC;
            }
            Camera.main.transform.localPosition = Vector3.zero;
            Camera.main.transform.localRotation = Quaternion.identity;
            effects.GetChild(id).gameObject.SetActive(true);
            Name.text = effects.GetChild(id).name;
        }

        public void ButtonLightOnClick()
        {
            if(lightA.childCount == 0)
            {
                Light.parent = lightA;
                Light.localRotation = Quaternion.identity;
            }
            else if(lightB.childCount == 0)
            {
                Light.parent = lightB;
                Light.localRotation = Quaternion.identity;
            }
        }
    }

}
