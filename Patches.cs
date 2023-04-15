using UnityEngine;
using MelonLoader;

namespace CleanPack
{
    public class Patches : MelonMod
    {
        public override void OnSceneWasInitialized(int level, string name)
        {
            if (name == "LakeRegion_SANDBOX")
            {
                GameObject[] cupObjects = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] basinObjects = GameObject.FindObjectsOfType<GameObject>();

                foreach (GameObject obj in cupObjects)
                {
                    if (obj.name == "OBJ_CupA_Prefab")
                    {
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in basinObjects)
                {
                    if (obj.name == "OBJ_BasinA_Prefab")
                    {
                        obj.SetActive(false);
                    }
                }

                GameObject.Find("OBJ_PitcherA_Prefab").gameObject.SetActive(false);
                GameObject.Find("OBJ_SoapA_Prefab").gameObject.SetActive(false);
            }

            if (name == "CanneryRegion_SANDBOX")
            {
                GameObject.Find("Design/Containers/CONTAINER_PlasticBox").transform.SetPositionAndRotation(new Vector3(300.5999f, 239.4692f, 348.2f), Quaternion.Euler(new Vector3(0, 114, 0)));
                GameObject.Find("Design/Containers/CONTAINER_TrashCanister").transform.SetPositionAndRotation(new Vector3(297.1f, 239, 351.6998f), Quaternion.Euler(new Vector3(359, 209, 0)));
                GameObject.Find("Design/Containers/CONTAINER_SteamerTrunk").transform.SetPositionAndRotation(new Vector3(300.2f, 239, 353.2999f), Quaternion.Euler(new Vector3(0, 206, 0)));
                GameObject.Find("Art/LookoutTower/OBJ_CandyBoxD_Prefab").transform.SetPositionAndRotation(new Vector3(300.635f, 240.1696f, 348.4f), Quaternion.Euler(new Vector3(0, 224, 0)));

                GameObject.Find("/Art/LookoutTower/OBJ_ClothesHanger_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_ChairFoldng_A_Open_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_ComputerMouse_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CupA_Prefab (6)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_Kettle_A_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_RugG_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_RugG_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_PottedPlantA_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CupE_Prefab (5)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishServeB3_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishServeB3_Prefab (3)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishServeB3_Prefab (4)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishServeB3_Prefab (5)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishServeB3_Prefab (6)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_PitcherA_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CupA_Prefab (7)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CupA_Prefab (8)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_SoapA_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_DishBowlA1_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_ToasterOven_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_WoodSpatulaSpoon_Prefab (2)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_DishServeB3_Prefab").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_DishServeB3_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_PitcherA_Prefab (1)").gameObject.SetActive(false);
                GameObject.Find("/Art/LookoutTower/OBJ_CounterCorner_Prefab/OBJ_CoffeeMachine_Prefab").gameObject.SetActive(false);
            }
        }
    }
}