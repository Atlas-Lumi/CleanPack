using UnityEngine;
using MelonLoader;

namespace CleanPack
{
    public class Patches : MelonMod
    {
        public override void OnSceneWasInitialized(int level, string name)
        {

            if (name == "CoastalRegion_SANDBOX")
            {
                GameObject.Find("INTERACTIVE_BedMattressB").transform.SetPositionAndRotation(new Vector3(358.154f, 203.256f, 1155.33f), Quaternion.Euler(new Vector3(0, 97, 0)));
            }

            if (name == "AirfieldRegion_SANDBOX")
            {
                GameObject[] cupObjects = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] milkCrates = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] dishPlates = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] spatulas = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] plantPots = GameObject.FindObjectsOfType<GameObject>();
                GameObject[] rugs = GameObject.FindObjectsOfType<GameObject>();

                foreach (GameObject obj in cupObjects)
                {
                    if (obj.name.StartsWith("OBJ_CupA_Prefab"))
                    {
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in milkCrates)
                {
                    if (obj.name.StartsWith("OBJ_MilkCrateA_Prefab"))
                    {
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in dishPlates)
                {
                    if (obj.name.StartsWith("OBJ_DishPlate"))
                    { 
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in spatulas)
                {
                    if (obj.name.StartsWith("OBJ_WoodSpatulaSpoon_Prefab"))
                    {
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in plantPots)
                {
                    if (obj.name.StartsWith("OBJ_PottedPlant"))
                    {
                        obj.SetActive(false);
                    }
                }

                foreach (GameObject obj in rugs)
                {
                    if (obj.name.StartsWith("Lit Art/STR_SteepCabinA_InteriorObjects_Prefab/Interior Objects/OBJ_Rug"))
                    {
                        obj.SetActive(false);
                    }
                }

                GameObject.Find("CONTAINER_TrashCanister").SetActive(false);
            }

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

                GameObject.Find("Design/Gear/RareFlareGun/ContainerFlareGun/CONTAINER_FlareGun").transform.SetPositionAndRotation(new Vector3(790.2501f, 214.1309f, 969.8069f), Quaternion.Euler(new Vector3(0, 76, 0)));
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