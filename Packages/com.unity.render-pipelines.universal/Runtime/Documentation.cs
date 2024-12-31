using System.Diagnostics;

namespace UnityEngine.Rendering.Universal
{
    [Conditional("UNITY_EDITOR")]
    internal class URPHelpURLAttribute : CoreRPHelpURLAttribute
    {
        public URPHelpURLAttribute(string pageName, string pageHash = "")
            : base(pageName, pageHash, Documentation.packageName)
        {
        }
    }

    #region HDRP

    [Conditional("UNITY_EDITOR")]
    internal class HDRPHelpURLAttribute : CoreRPHelpURLAttribute
    {
        public HDRPHelpURLAttribute(string pageName)
            : base(pageName, Documentation.packageName)
        {
        }
    }

    #endregion // HDRP

    internal class Documentation : DocumentationInfo
    {
        /// <summary>
        /// The name of the package
        /// </summary>
        public const string packageName = "com.unity.render-pipelines.universal";

        #region HDRP

        /// <summary>
        /// Generates a help url for the given package and page name
        /// </summary>
        /// <param name="pageName">The page name</param>
        /// <returns>The full url page</returns>
        public static string GetPageLink(string pageName) => GetPageLink(packageName, pageName);

        #endregion // HDRP
    }
}
