#ifndef CUSTOM_PASS_RENDERERS
#define CUSTOM_PASS_RENDERERS

#define SHADERPASS SHADERPASS_FORWARD_UNLIT

//-------------------------------------------------------------------------------------
// Define
//-------------------------------------------------------------------------------------

#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/ShaderLibrary/ShaderVariables.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/FragInputs.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/ShaderPass.cs.hlsl"

#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Unlit/UnlitProperties.hlsl"

#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Material.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Unlit/Unlit.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/ShaderPass/VaryingMesh.hlsl"

#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Sampling/SampleUVMapping.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/BuiltinUtilities.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/MaterialUtilities.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/Decal/DecalUtilities.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/RenderPass/CustomPass/CustomPassSampling.hlsl"

float _FadeValue;

#endif // CUSTOM_PASS_RENDERERS
