using UnityEngine;

namespace GraphViewBase {
    public interface ISelectable {
        ISelector Selector { get; }
        bool Selected { get; set; }
        bool Hovered { get; set; }
        bool Overlaps(Rect rectangle);
        bool ContainsPoint(Vector2 localPoint);
    }
}