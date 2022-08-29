using UnityEngine;

public class DetectionSystem : MonoBehaviour
{

    public static Collider Detect(string gameobjectTag, Transform gameObjectPosition, float radius = 1f, bool detected = false)
    {

        var colliders = Physics.OverlapSphere(gameObjectPosition.position, radius);
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(gameobjectTag))
            {
                    detected = true;
                    return collider;
            }
        }
        return null;
    }
    public static void LookAndFollow(GameObject actor, Transform TargetToLook, Transform startPosition, Transform targetPosition, float speed=1f)
    {
        actor.transform.LookAt(TargetToLook);
        actor.transform.position = Vector3.MoveTowards(startPosition.position, targetPosition.position, speed * Time.deltaTime);
    }

}

