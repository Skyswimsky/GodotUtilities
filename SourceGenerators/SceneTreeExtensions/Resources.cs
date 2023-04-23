﻿using System.Reflection;

namespace GodotSharp.SourceGenerators.SceneTreeExtensions
{
    internal static class Resources
    {
        private const string sceneTreeTemplate = "GodotSharp.SourceGenerators.SceneTreeExtensions.SceneTreeTemplate.sbncs";
        public static readonly string SceneTreeTemplate = Assembly.GetExecutingAssembly().GetEmbeddedResource(sceneTreeTemplate);
        private const string nodeAttributeTemplate = "GodotSharp.SourceGenerators.SceneTreeExtensions.NodeAttributeTemplate.sbncs";
        public static readonly string NodeAttributeTemplate = Assembly.GetExecutingAssembly().GetEmbeddedResource(nodeAttributeTemplate);
    }
}
