namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// Utility class for component checks.
    /// </summary>
    public static class ComponentUtility
    {
        /// <summary> Check if the provided camera is compatible with Universal Render Pipeline </summary>
        /// <param name="camera">The Camera to check</param>
        /// <returns>True if it is compatible, false otherwise</returns>
        public static bool IsUniversalCamera(Camera camera)
            => camera.GetComponent<UniversalAdditionalCameraData>() != null;

        /// <summary> Check if the provided light is compatible with Universal Render Pipeline </summary>
        /// <param name="light">The Light to check</param>
        /// <returns>True if it is compatible, false otherwise</returns>
        public static bool IsUniversalLight(Light light)
            => light.GetComponent<UniversalAdditionalLightData>() != null;

        #region HDRP

        /// <summary> Check if the provided camera is compatible with High-Definition Render Pipeline </summary>
        /// <param name="camera">The Camera to check</param>
        /// <returns>True if it is compatible, false otherwise</returns>
        public static bool IsHDCamera(Camera camera)
            => camera.TryGetComponent<UniversalAdditionalCameraData>(out var _);

        /// <summary> Check if the provided light is compatible with High-Definition Render Pipeline </summary>
        /// <param name="light">The Light to check</param>
        /// <returns>True if it is compatible, false otherwise</returns>
        public static bool IsHDLight(Light light)
            => light.TryGetComponent<UniversalAdditionalLightData>(out var _);

        /// <summary> Check if the provided reflection probe is compatible with High-Definition Render Pipeline </summary>
        /// <param name="reflectionProbe">The ReflectionProbe to check</param>
        /// <returns>True if it is compatible, false otherwise</returns>
        public static bool IsHDReflectionProbe(ReflectionProbe reflectionProbe)
            //=> reflectionProbe.GetComponent<HDAdditionalReflectionData>() != null;
            => true;

        #endregion // HDRP
    }
}
