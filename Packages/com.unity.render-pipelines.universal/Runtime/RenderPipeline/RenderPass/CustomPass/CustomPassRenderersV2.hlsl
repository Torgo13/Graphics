#ifndef CUSTOM_PASS_RENDERERS_V2
#define CUSTOM_PASS_RENDERERS_V2

#define SHADERPASS SHADERPASS_FORWARD_UNLIT

//-------------------------------------------------------------------------------------
// Define
//-------------------------------------------------------------------------------------

#include "Packages/com.unity.render-pipelines.universal/Runtime/ShaderLibrary/ShaderVariables.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/FragInputs.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/ShaderPass.cs.hlsl"

#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Material.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Unlit/Unlit.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/VaryingMesh.hlsl"

#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Sampling/SampleUVMapping.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/BuiltinUtilities.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/MaterialUtilities.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Decal/DecalUtilities.hlsl"

float _CustomPassInjectionPoint;
float _FadeValue;

#endif // CUSTOM_PASS_RENDERERS_V2
