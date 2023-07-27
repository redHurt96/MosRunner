using System.Linq;
using _Project.Logic.Level;
using UnityEditor;
using UnityEngine;

namespace _Project.Logic.Editor
{
    public static class CarsEditor
    {
        [MenuItem("Project/Cars/Prepare")]
        private static void PrepareCars()
        {
            foreach (Transform car in Selection.gameObjects.Select(x => x.transform))
            {
                foreach (Transform carChild in car)
                {
                    if (carChild.gameObject.name.Contains("body"))
                    {
                        if (!carChild.TryGetComponent(out MeshCollider collider))
                            collider = carChild.gameObject.AddComponent<MeshCollider>();

                        collider.convex = true;
                        collider.isTrigger = true;

                        if (!carChild.TryGetComponent(out ObstacleTrigger trigger))
                            carChild.gameObject.AddComponent<ObstacleTrigger>();
                    }
                }
                
                EditorUtility.SetDirty(car.gameObject);
            }
        }

        [MenuItem("Project/Cars/Move up")]
        private static void MoveUpCars()
        {
            foreach (Transform car in Selection.gameObjects.Select(x => x.transform))
            {
                foreach (Transform carChild in car) 
                    carChild.Translate(Vector3.up * .22f);

                EditorUtility.SetDirty(car.gameObject);
            }
        }
    }
}
