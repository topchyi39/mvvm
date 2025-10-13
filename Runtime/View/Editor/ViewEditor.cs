#if UNITY_EDITOR

using UnityEditor;

namespace Mvvm.View.Editor
{
    [CustomEditor(typeof(View), true)]
    public class ViewEditor : UnityEditor.Editor { }
}

#endif