using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for container widget.
    /// </summary>
    public class DebugUIHandlerContainer : MonoBehaviour
    {
        /// <summary>Content holder.</summary>
        [SerializeField]
        public RectTransform contentHolder;

        internal DebugUIHandlerWidget GetFirstItem()
        {
            if (contentHolder.childCount == 0)
                return null;

            var items = GetActiveChildren();

            if (items.Count == 0)
                return null;

            return items[0];
        }

        internal DebugUIHandlerWidget GetLastItem()
        {
            if (contentHolder.childCount == 0)
                return null;

            var items = GetActiveChildren();

            if (items.Count == 0)
                return null;

            return items[items.Count - 1];
        }

        internal bool IsDirectChild(DebugUIHandlerWidget widget)
        {
            if (contentHolder.childCount == 0)
                return false;

            return GetActiveChildren()
#if OPTIMISATION
                .Any(x => x == widget);
#else
                .Count(x => x == widget) > 0;
#endif // OPTIMISATION
        }

        List<DebugUIHandlerWidget> GetActiveChildren()
        {
            var list = new List<DebugUIHandlerWidget>();

            foreach (Transform t in contentHolder)
            {
                if (!t.gameObject.activeInHierarchy)
                    continue;

#if OPTIMISATION_TRYGET
                if (t.TryGetComponent<DebugUIHandlerWidget>(out var c))
#else
                var c = t.GetComponent<DebugUIHandlerWidget>();
                if (c != null)
#endif // OPTIMISATION_TRYGET
                    list.Add(c);
            }

            return list;
        }
    }
}
